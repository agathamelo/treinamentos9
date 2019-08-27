using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreinamentoApi.Models.Entities;

namespace TreinamentoApi.Helpers.DataTransferObject
{
    public class PessoaDto
    {
        public string nome;
        public long id;
        public string telefone;
        public string email;
        public string cpf;
        public long idade;
        public string cnpj;
        public string razaosocial;
        public EnumTipoConta tipoconta;
       

        public PessoaDto(Pessoa pessoa)
        {
            this.nome = pessoa.Nome;
            this.id = pessoa.Id;
            this.telefone = pessoa.Telefone;
            this.email = pessoa.Email;
            this.tipoconta = pessoa.TipoConta;
            if (pessoa.PessoaFisica != null)
            {
                this.cpf = pessoa.PessoaFisica.Cpf;
                this.idade = pessoa.PessoaFisica.Idade;
            }
            if(pessoa.PessoaJuridica != null)
            {
                this.cnpj = pessoa.PessoaJuridica.Cnpj;
                this.razaosocial = pessoa.PessoaJuridica.RazaoSocial;
            }
        }
    }
}
