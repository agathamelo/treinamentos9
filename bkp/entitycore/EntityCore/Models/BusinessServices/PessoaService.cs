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
        public async Task<Pessoa> Obter(long id)
        {
            var r = await _repository.Obter(id);

            return r;
        }


        public async Task<Pessoa> Cadastrar(Pessoa pessoa)
        {
            var novapessoa = new Pessoa();
            novapessoa.Nome = pessoa.Nome;
            novapessoa.Email = pessoa.Email;

            await _repository.Criar(novapessoa);
            await _repository.Persistir();

            return novapessoa;
        }

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
        public async Task<List<Pessoa>> ObterTodos()
        {
            var r =  _repository.Obter();
          
            return r.ToList();
        }

        public async Task<Pessoa> ObterPorNome(string nome)
        {
            var pessoanome = _repository.Obter(x=>x.Nome.Contains(nome));

            return pessoanome.FirstOrDefault();
        }
        //public async Task Delete(long id)
        //{
        //    var pessoa = await _repository.Obter(id);

        //    if (pessoa != null)
        //    {
        //       await _repository.Excluir(pessoa);
        //    }
        //    else
        //    {
        //        throw new Exception("Pessoa não existe.");
        //    }
        //}

    }
}
