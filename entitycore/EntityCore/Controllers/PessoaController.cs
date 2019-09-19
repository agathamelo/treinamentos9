using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityCore.Helpers.DataTransferObjects;
using EntityCore.Models.BusinessModels;
using EntityCore.Models.BusinessModels.Entities;
using EntityCore.Models.BusinessServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        public readonly CoreService _core;
        public PessoaController(CoreService coreService)
        {
            this._core = coreService;
        }

        //obter pessoa por id
        [HttpGet("{id:long}")]
        public async Task<ActionResult<PessoaDto>> BuscarPorId(long id)
        {
            var pessoa = await this._core.PessoaService.ObterPorId(id);

            return new PessoaDto(pessoa);
        }


        //Obter pessoa por id e classe endereço
        //[HttpGet("{id:long")]
        //public async Task<ActionResult<Pessoa>> ObterPorId(long id)
        //{
        //    var pessoaPesquisada = await this._core.PessoaService.Obter(id);

        //    return pessoaPesquisada;
        //}


        //cadastrar pessoa retornando pessoa cadastrada
        [HttpPost ("")]
        public async Task<ActionResult<PessoaDto>> Cadastrar (Pessoa pessoa)
        {
            var p = await _core.PessoaService.Cadastrar(pessoa);

            return new PessoaDto(p);
        }


        //obter todas as pessoas
        [HttpGet ("")]
        public async Task<ActionResult<IEnumerable<PessoaDto>>> ObterTodos ()
        {
            var listaPessoa = await _core.PessoaService.ObterTodos();

            var retorna = listaPessoa.Select(x => new PessoaDto(x));

            return Ok(retorna);
        }


        //pesquisar pessoa por nome
        [HttpGet("{nome}")]
        public async Task<ActionResult<PessoaDto>> ObterPorNome (string nome)
        {
            var pessoaPesquisada = await _core.PessoaService.ObterPorNome(nome);

            return Ok(pessoaPesquisada);
        }


        //editar dados de uma pessoa e retornar pessoa editada
        [HttpPut("{id:long}")]
        public async Task<ActionResult<PessoaDto>> Editar(Pessoa pessoa, long id)
        {
            var pessoaEditada = await _core.PessoaService.Editar(pessoa, id);

            return new PessoaDto(pessoaEditada);
        }


        //desativar pessoa no banco de dados
        [HttpDelete("{id:long}")]
        public async Task<ActionResult> Deletar(long id)
        {
            await _core.PessoaService.Delete(id);

            return Ok();
        }
    }
}