using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TreinamentoApi.Helpers.DataTransferObject;
using TreinamentoApi.Helpers.Posts;
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

            PessoaTipoFisica.Cpf = "09110012800";

            PessoaTipoFisica.Idade = 56;
            pessoa1.PessoaFisica = PessoaTipoFisica;

            var SaldoDisponivel = new Conta();
            SaldoDisponivel.Saldo = 1000.00m;
            pessoa1.Conta = SaldoDisponivel;

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

            var SaldoDisponivel2 = new Conta();
            SaldoDisponivel2.Saldo = 1000.00m;
            pessoa2.Conta = SaldoDisponivel2;


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

            var SaldoDisponivel3 = new Conta();
            SaldoDisponivel3.Saldo = 1000.00m;
            pessoa3.Conta = SaldoDisponivel3;

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

            var SaldoDisponivel4 = new Conta();
            SaldoDisponivel4.Saldo = 1000.00m;

            pessoa4.Conta = SaldoDisponivel4;

            lista.Add(pessoa4);

            var pessoa5 = new Pessoa();
            pessoa5.TipoConta = EnumTipoConta.PessoaFisica;
            pessoa5.Nome = "kathlen";
            pessoa5.Id = 5;

            var PessoaFisica3 = new PessoaFisica();
            PessoaFisica3.Cpf = "42229266802";
            pessoa5.PessoaFisica = PessoaFisica3;

            var SaldoDisponivel5 = new Conta();
            SaldoDisponivel5.Saldo = 1000.00m;
            pessoa5.Conta = SaldoDisponivel5;

            lista.Add(pessoa5);
        }

        //Buscando a lista de pessoas fisicas e juridicas
        //[HttpGet("pessoas")]
        //public ActionResult<List<Pessoa>> Get()
        //{            
        //    return lista;
        //}



        //Buscando pessoa pelo numero de Id
        //[HttpGet("pessoas/{id:long}")]
        //public ActionResult<Pessoa> GetById(long id)
        //{
        //    var pesquisando = lista.Where(x => x.Id == id).FirstOrDefault();

        //    return pesquisando;
        //}



        //Buscando pessoa pelo numero do cpf
        //[HttpGet("pessoas/{cpf}")]
        //public ActionResult<Pessoa> GetByCpf(string cpf)
        //{
        //    var pesquisando = lista.Where(x =>x.PessoaFisica != null && x.PessoaFisica.Cpf == cpf).FirstOrDefault();

        //    return pesquisando;
        //}



        //Buscando pessoa pelo numero do cnpj
        //[HttpGet("pessoas/{cnpj}")]
        //public ActionResult<Pessoa> GetByCnpj(string cnpj)
        //{
        //    var pesquisando = lista.Where(x => x.PessoaJuridica != null && x.PessoaJuridica.Cnpj == cnpj).FirstOrDefault();

        //    return pesquisando;
        //}



        //Buscando pessoa pelo cpf ou cnpj
        //[HttpGet ("pessoas/{codigo}")]
        //public ActionResult<Pessoa> GetByCodigo(string codigo)
        //{
        //    var pessoa = lista.Where(x => x.PessoaFisica != null && x.PessoaFisica.Cpf == codigo
        //                            || x.PessoaJuridica != null && x.PessoaJuridica.Cnpj == codigo)
        //                            .FirstOrDefault();
        //    if (pessoa == null)
        //        return BadRequest();

        //    return Ok(pessoa);
        //}



        //Enviando dados de uma pessoa
        //[HttpPost]
        //[Route("pessoas")]
        //public ActionResult Post(Pessoa pessoa)
        //{
        //    lista.Add(pessoa);

        //    return Ok("Pessoa cadastrada");
        //}



        //Verificando se dados enviados ja possuem cadastro
        //[HttpPost]
        //[Route("pessoas")]
        //public ActionResult Verificando(Pessoa pessoa)
        //{
        //    var codigo = "";

        //    if (pessoa.PessoaFisica != null)
        //    {
        //        codigo = pessoa.PessoaFisica.Cpf;
        //    }
        //    if (pessoa.PessoaJuridica != null)
        //    {
        //        codigo = pessoa.PessoaJuridica.Cnpj;
        //    }

        //    var pesquisando = lista.Where(x => x.PessoaFisica != null && x.PessoaFisica.Cpf == codigo
        //                            || x.PessoaJuridica != null && x.PessoaJuridica.Cnpj == codigo)
        //                            .FirstOrDefault();
        //    if (pesquisando != null)
        //        return BadRequest();

        //    lista.Add(pessoa);

        //    return Ok(pessoa);

        //}

        //ou

        //[HttpPost]
        //[Route("pessoas")]
        //public ActionResult Verificar (Pessoa pessoa)
        //{

        //    var codigo = pessoa.PessoaFisica != null ? pessoa.PessoaFisica.Cpf : pessoa.PessoaJuridica.Cnpj;

        //    var pesquisa = lista.Where(x => x.PessoaFisica != null && x.PessoaFisica.Cpf == codigo 
        //                            || x.PessoaJuridica != null && x.PessoaJuridica.Cnpj == codigo)
        //                            .FirstOrDefault();
        //    if (pesquisa != null)
        //    {
        //        return BadRequest();
        //    }

        //    lista.Add(pessoa);
        //    return Ok(pessoa);
        //}



        //Devolver uma lista de pessoas que o nome possua a letra com A
        //[HttpGet]
        //[Route("pessoas/{termo}")]
        //public ActionResult<List<Pessoa>> RetornaLetra (string termo )
        //{
        //    //Contains - determina se um elemento existe na lista 
        //    var pesquisando = lista.Where(x => x.Nome.Contains(termo));

        //    return Ok(pesquisando);
        //}



        //Devolver lista com nome e id de pessoa
        //[HttpGet]
        //[Route ("pessoas/{termo}")]
        //public ActionResult<List<object>> RetornaNomeEId (string termo)
        //{
        //    var pesquisando = lista.Where(x => x.Nome.Contains(termo));

        //    //Select - Projeta cada elemento de uma sequência em um novo formulário.
        //    var retorno = pesquisando.Select(x => new { nome = x.Nome, id = x.Id });
        //    return Ok(retorno);
        //}



        //Devolver lista de pessoas ordenadas pelo id de maneira descendente 
        //[HttpGet]
        //[Route ("pessoas/{termo}")]
        //public ActionResult<List<object>> DevolveId (string termo)
        //{
        //    var pesquisando = lista.Where(x => x.Nome.Contains(termo));

        //    var retorno = pesquisando.Select(x => new { nome = x.Nome, id = x.Id });

        //    return Ok(retorno.OrderByDescending(x=>x.id));
        //}



        //[HttpGet]
        //[Route("pessoas/{termo}")]
        //public ActionResult<List<object>> DevolveId(string termo)
        //{
        //    var pesquisando = lista.Where(x => x.Nome.Contains(termo));

        //    var retorno = pesquisando.Select(x => new PessoaDto(x));

        //    return Ok(retorno.OrderByDescending(x => x.id));
        //}



        //Adicionando uma nova pessoa na lista e retornando lista de PessoaDto
        //[HttpPost]
        //[Route("pessoas")]
        //public ActionResult Cadastrar (Pessoa novapessoa)
        //{
        //    lista.Add(novapessoa);


        //    return Ok(new PessoaDto(novapessoa));
        //}



        //Deletando uma pessoa da lista pelo id
        //[HttpDelete]
        //[Route("pessoas/{id:long}")]
        //public ActionResult<List<Pessoa>> DeletePessoa(long id)
        //{
        //    var pesquisando = lista.Where(x => x.Id == id).FirstOrDefault();
           
        //    var indexador = lista.IndexOf(pesquisando);
        //    lista.RemoveAt(indexador);

        //    return lista;
        //}



        //Deletando uma pessoa pelo email
        //[HttpDelete]
        //[Route("pessoas/{email}")]
        //public ActionResult<List<Pessoa>> DeletarPorEmail (string email)
        //{
        //    var pesquisando = lista.Where(x => x.Email == email).FirstOrDefault();

        //    var indexador = lista.IndexOf(pesquisando);
        //    lista.RemoveAt(indexador);

        //    return lista;
        //}



        //Editando dados de uma pessoa da lista
        //[HttpPut]
        //[Route("pessoas/{id:long}")]
        //public ActionResult<List<Pessoa>> EditandoPessoa(long id, Pessoa pessoa)
        //{
        //    var pessoaEdicao = lista.Where(x => x.Id == id).FirstOrDefault();

        //    if(pessoaEdicao == null)
        //    {
        //        return BadRequest();
        //    }
        //    pessoaEdicao.Nome = pessoa.Nome;
        //    pessoaEdicao.Id = pessoa.Id;
        //    pessoaEdicao.Email = pessoa.Email;
        //    pessoaEdicao.Telefone = pessoa.Telefone;
        //    pessoaEdicao.TipoConta = pessoa.TipoConta;
        //    if(pessoa.PessoaFisica != null && pessoaEdicao.PessoaFisica != null)
        //    {
        //        pessoaEdicao.PessoaFisica.Cpf = pessoa.PessoaFisica.Cpf;
        //        pessoaEdicao.PessoaFisica.Idade = pessoa.PessoaFisica.Idade;
        //    }
        //    if(pessoa.PessoaJuridica != null && pessoaEdicao.PessoaJuridica != null)
        //    {
        //        pessoaEdicao.PessoaJuridica.Cnpj = pessoa.PessoaJuridica.Cnpj;
        //        pessoaEdicao.PessoaJuridica.RazaoSocial = pessoa.PessoaJuridica.RazaoSocial;
        //    }

        //    return lista;
        //}



        //Editando uma pessoa pelo numero do cpf ou cnpj
        //[HttpPut]
        //[Route("pessoas/{codigo}")]
        //public ActionResult<List<Pessoa>> EditandoTermo(string codigo, Pessoa pessoa)
        //{
        //    var pessoaEdicao = lista.Where(x => x.PessoaFisica != null && x.PessoaFisica.Cpf == codigo 
        //                                || x.PessoaJuridica != null && x.PessoaJuridica.Cnpj == codigo)
        //                                .FirstOrDefault();
        //    if (pessoaEdicao == null)
        //        return BadRequest();

        //    pessoaEdicao.Id = pessoa.Id;
        //    pessoaEdicao.Nome = pessoa.Nome;
        //    pessoaEdicao.Telefone = pessoa.Telefone;
        //    pessoaEdicao.Email = pessoa.Email;
        //    if (pessoa.PessoaFisica != null && pessoaEdicao.PessoaFisica != null)
        //    {
        //        pessoaEdicao.PessoaFisica.Cpf = pessoa.PessoaFisica.Cpf;
        //        pessoaEdicao.PessoaFisica.Idade = pessoa.PessoaFisica.Idade;
        //    }
        //    if (pessoa.PessoaJuridica != null && pessoaEdicao.PessoaJuridica != null)
        //    {
        //        pessoaEdicao.PessoaJuridica.Cnpj = pessoa.PessoaJuridica.Cnpj;
        //        pessoaEdicao.PessoaJuridica.RazaoSocial = pessoa.PessoaJuridica.RazaoSocial;
        //    }

        //    return lista;
        //}



        
        [HttpPost]
        [Route("pessoas/{id:long}/compra")]
        public ActionResult<Pessoa> Compra(long id,PostCompra compra)
        {
            if (compra.Valor != null && compra.Valor > 0 && compra.Nome != null)
            {

            }
            else
                return BadRequest();
        }
    }
}
