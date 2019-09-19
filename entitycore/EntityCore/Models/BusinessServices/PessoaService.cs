using EntityCore.Models.BusinessModels.Entities;
using EntityTeste.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCore.Models.BusinessServices
{
    public class PessoaService
    {

        private readonly BaseRepository<Pessoa> _repository;

        public PessoaService(BaseRepository<Pessoa> repository)
        {
            _repository = repository;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
      

        //obter pessoa por id
        public async Task<Pessoa> ObterPorId(long id)
        {
            var pessoa = await _repository.Obter(id);

            if(pessoa == null || !pessoa.Status)
            {
                throw new Exception("A pessoa esta desativada."); 
            }

            return pessoa;
        }


        //cadastrar pessoa
        public async Task<Pessoa> Cadastrar(Pessoa pessoa)
        {
            var novapessoa = new Pessoa();
            novapessoa.Nome = pessoa.Nome;
            novapessoa.Email = pessoa.Email;
            novapessoa.Status = true; 

            await _repository.Criar(novapessoa);
            await _repository.Persistir();

            return novapessoa;
        }

        //editar pessoa
        public async Task<Pessoa> Editar(Pessoa pessoa, long id)
        {
            var pessoaParaEditar = await _repository.Obter(id);

            pessoaParaEditar.Nome = pessoa.Nome;
            pessoaParaEditar.Email = pessoa.Email;
            await _repository.Editar(pessoaParaEditar, pessoaParaEditar.Id);
            await _repository.Persistir();

            return pessoaParaEditar;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //Obter lista com todas as pessoas
        public async Task<List<Pessoa>> ObterTodos()
        {
            var r =  _repository.Obter();
          
            return r.ToList();
        }

        //obter pessoa por nome 
        public async Task<Pessoa> ObterPorNome(string nome)
        {
            var pessoanome = _repository.Obter(x=>x.Nome.Contains(nome));

            return pessoanome.FirstOrDefault();
        }

        //deletar pessoa
        public async Task Delete(long id)
        {
            var pessoaParaEditar = await this.ObterPorId(id);
            
            pessoaParaEditar.Status = false;
            
            await _repository.Editar(pessoaParaEditar, pessoaParaEditar.Id);
            await _repository.Persistir();
            
        }

    }
}
