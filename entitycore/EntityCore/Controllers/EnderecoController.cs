using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityCore.Helpers.DataTransferObjects;
using EntityCore.Models.BusinessModels.Entities;
using EntityCore.Models.BusinessServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        public readonly CoreService _core;
        public EnderecoController(CoreService coreService)
        {
            this._core = coreService;
        }

        //cadastrar endereco
        [HttpPost("~/api/pessoa/endereco/{id:long}")]
        public async Task<ActionResult<EnderecoDto>> Cadastrar(Endereco endereco, long id)
        {
            var enderecoCadastrado = await _core.EnderecoService.Cadastrar(endereco, id);

            return new EnderecoDto(enderecoCadastrado);
        }

        //Obter endereco por id
        [HttpGet("{id:long}")]
        public async Task<ActionResult<EnderecoDto>> ObterEndereco(long id)
        {
            var endereco = await _core.EnderecoService.ObterPorId(id);

            return new EnderecoDto(endereco);
        }

        //Editar endereco
        [HttpPut("{id:long}")]
        public async Task<ActionResult<EnderecoDto>> Editar(Endereco endereco,long id)
        {
            var enderecoEditado = await _core.EnderecoService.Editar(endereco,id);

            return Ok(enderecoEditado);
        }

        //Desativar endereco
        [HttpDelete("{id:long}")]
        public async Task<ActionResult> Desativar(long id)
        {
            await _core.EnderecoService.Desativar(id);

            return Ok("Endereço Desativado com sucesso.");
        }
    }
}