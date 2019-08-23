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
        public List<Pessoa> lista = new List<Pessoa>();

        public ValuesController()
      
        {          
            var pessoa1 = new Pessoa();
            pessoa1.TipoConta = EnumTipoConta.PessoaFisica;
            pessoa1.Id = 1;
            pessoa1.Nome = "tania";
            pessoa1.Telefone = "11992426199";
            pessoa1.Email = "tamabra16@gmail.com";

            var PessoaTipoFisica = new PessoaFisica();
            PessoaTipoFisica.Cpf = "091100128/00";
            PessoaTipoFisica.Idade = 56;
            pessoa1.PessoaFisica = PessoaTipoFisica;

            lista.Add(pessoa1);

            var pessoa2 = new Pessoa { };
            pessoa2.TipoConta = EnumTipoConta.PessoaFisica;
            pessoa2.Id = 2;
            pessoa2.Nome = "Agatha";
            pessoa2.Telefone = "11 965395313";
            pessoa2.Email = "agatha.m.f@hotmail.com";

            var PessoaTipoFisica2 = new PessoaFisica();
            PessoaTipoFisica2.Cpf = "42229265822";
            PessoaTipoFisica2.Idade = 24;
            pessoa2.PessoaFisica = PessoaTipoFisica2;


            lista.Add(pessoa2);

            var pessoa3 = new Pessoa { };
            pessoa3.TipoConta = EnumTipoConta.PessoaJuridica;
            pessoa3.Id = 3;
            pessoa3.Nome = "kathlen";
            pessoa3.Telefone = "11 948543698";
            pessoa3.Email = "kathlenmf@gmail.com";

            var PessoaTipoJuridica1 = new PessoaJuridica();
            PessoaTipoJuridica1.Cnpj = "18621462145215";
            PessoaTipoJuridica1.RazaoSocial = "Puteiro";

            pessoa3.PessoaJuridica = PessoaTipoJuridica1;

            lista.Add(pessoa3);

            var pessoa4 = new Pessoa { };
            pessoa4.TipoConta = EnumTipoConta.PessoaJuridica;
            pessoa4.Id = 4;
            pessoa4.Nome = "alberto";
            pessoa4.Telefone = "11 969398742";
            pessoa4.Email = "alberto.roque097@hotmail.com";

            var PessoaTipoJuridica2 = new PessoaJuridica();
            PessoaTipoJuridica2.Cnpj = "85286585485585";
            PessoaTipoJuridica2.RazaoSocial = "Catáloko";
            pessoa4.PessoaJuridica = PessoaTipoJuridica2;

            lista.Add(pessoa4);
        }

        [HttpGet("pessoas")]
        public ActionResult<List<Pessoa>> Get()
        {            
            return lista;
        }


        [HttpGet("pessoas/{id:long}")]
        public ActionResult<Pessoa> GetById(long id)
        {
            var pesquisando = lista.Where(x => x.Id == id).FirstOrDefault();

            return pesquisando;
        }
    }
}
