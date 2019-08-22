using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreinamentoApi.Models.Entities
{
    public class Pessoa
    {
        public long Id;
        public string Nome;
        public string Telefone;
        public string Email;
        public enum TipoConta
        {
            PessoaFisica =1,
            PessoaJuridica
        }
        public Conta Conta;
        
        public PessoaFisica PessoaFisica;
        public PessoaJuridica PessoaJuridica;
    }
}
