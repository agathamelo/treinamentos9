using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreinamentoApi.Models.Entities;

namespace TreinamentoApi.Helpers.DataTransferObject
{
    public class SamplePessoaDto
    {
        public long id;
        public string nome;

        public SamplePessoaDto(Pessoa pessoa)
        {
            this.id = pessoa.Id;
            this.nome = pessoa.Nome;
        }
    }
}
