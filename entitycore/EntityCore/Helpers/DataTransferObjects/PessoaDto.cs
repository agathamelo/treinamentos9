using EntityCore.Models.BusinessModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCore.Helpers.DataTransferObjects
{
    public class PessoaDto
    {
        public long Id;

        public string Nome;
        public string Email;

        public PessoaDto(Pessoa pessoaDto)
        {
            this.Id = pessoaDto.Id;
            this.Nome = pessoaDto.Nome;
            this.Email = pessoaDto.Email;
        }
    }
}
