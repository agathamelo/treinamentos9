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
        public EnumTipoConta TipoConta;
       
        public Conta Conta;
        
        public PessoaFisica PessoaFisica;
        public PessoaJuridica PessoaJuridica;
        
    }

    public enum EnumTipoConta
    {
        PessoaFisica = 1,
        PessoaJuridica
    }
}
