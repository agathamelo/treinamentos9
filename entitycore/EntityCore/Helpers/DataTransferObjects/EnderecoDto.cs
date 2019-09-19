using EntityCore.Models.BusinessModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCore.Helpers.DataTransferObjects
{
    public class EnderecoDto
    {
        public long Id;
        public long IdPessoa;

        public string Logradouro;
        public string Numero;
        public string Complemento;
        public string Bairro;
        public string Estado;
        public string Cidade;
        public string Pais;
        public string Cep;
        public bool Status;
        
        public EnderecoDto(Endereco enderecoDto)
        {
            this.Id = enderecoDto.Id;
            this.IdPessoa = enderecoDto.IdPessoa;
            this.Logradouro = enderecoDto.Logradouro;
            this.Numero = enderecoDto.Numero;
            this.Complemento = enderecoDto.Complemento;
            this.Bairro = enderecoDto.Bairro;
            this.Cidade = enderecoDto.Cidade;
            this.Estado = enderecoDto.Estado;
            this.Pais = enderecoDto.Pais;
            this.Cep = enderecoDto.Cep;
            this.Status = enderecoDto.Status;
        }
    }
}
