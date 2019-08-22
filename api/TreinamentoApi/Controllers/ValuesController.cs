using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TreinamentoApi.Models.Entities;

namespace TreinamentoApi.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("teste1")]
       
        public ActionResult<Pessoa> Get()
        {
            var pessoa = new Pessoa();
            pessoa.Nome = "Agatha";
            pessoa.Id = 2019;
            pessoa.Telefone = "11 965395313";
            pessoa.Email = "agatha.m.f@hotmail.com";
            

            var pessoaFisica = new PessoaFisica();
            pessoaFisica.Cpf = "422292658/22";
            pessoaFisica.Idade = 24;
            
            pessoa.PessoaFisica = pessoaFisica;
            
            var conta = new Conta();
            conta.Saldo = 1000.00m;

            pessoa.Conta = conta;

            return pessoa;
        }
    }
}
