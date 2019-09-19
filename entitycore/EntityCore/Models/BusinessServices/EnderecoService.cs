using EntityCore.Models.BusinessModels.Entities;
using EntityTeste.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCore.Models.BusinessServices
{
    public class EnderecoService
    {
        private readonly BaseRepository<Endereco> _repository;

        public EnderecoService(BaseRepository<Endereco> repository)
        {
            _repository = repository;
        }

        //Cadastrar endereco
        public async Task<Endereco> Cadastrar(Endereco endereco, long id)
        {
            var novoendereco = new Endereco();

            novoendereco.Logradouro = endereco.Logradouro;
            novoendereco.Numero = endereco.Numero;
            novoendereco.Complemento = endereco.Complemento;
            novoendereco.Bairro = endereco.Bairro;
            novoendereco.Cidade = endereco.Cidade;
            novoendereco.Estado = endereco.Estado;
            novoendereco.Pais = endereco.Pais;
            novoendereco.Cep = endereco.Cep;
            novoendereco.IdPessoa = id;
            novoendereco.Status = true;

            await _repository.Criar(novoendereco);
            await _repository.Persistir();

            return novoendereco;
        }

        //Obter endereco por id
        public async Task<Endereco> ObterPorId (long id)
        {
            var endereco = await _repository.Obter(id);

            if(endereco == null || !endereco.Status)
            {
                throw new Exception("Endereco desativado.");
            }

            return endereco;
        }

        //Editar endereco
        public async Task<Endereco> Editar(Endereco endereco,long id)
        {
            var enderecoEditado = await _repository.Obter(id);

            enderecoEditado.Logradouro = endereco.Logradouro;
            enderecoEditado.Numero = endereco.Numero;
            enderecoEditado.Complemento = endereco.Complemento;
            enderecoEditado.Bairro = endereco.Bairro;
            enderecoEditado.Cidade = endereco.Cidade;
            enderecoEditado.Estado = endereco.Estado;
            enderecoEditado.Pais = endereco.Pais;
            enderecoEditado.Cep = endereco.Cep;

            await _repository.Editar(enderecoEditado, enderecoEditado.Id);
            await _repository.Persistir();

            return enderecoEditado;
        }

        //Desativar endereco
        public async Task Desativar(long id)
        {
            var enderecoDesativado = await this.ObterPorId(id);

            enderecoDesativado.Status = false;

            await _repository.Editar(enderecoDesativado, enderecoDesativado.Id);
            await _repository.Persistir();
        }
    }
}
