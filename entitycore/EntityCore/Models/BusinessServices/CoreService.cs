using EntityCore.Models.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCore.Models.BusinessServices
{
    public class CoreService
    {
        public PessoaService PessoaService { get; set; }
        public EnderecoService EnderecoService { get; set; }



        private readonly Context _db;

        public CoreService(Context db, PessoaService pessoaService, EnderecoService enderecoService)
        {
            _db = db;
            PessoaService = pessoaService;
            EnderecoService = enderecoService;
        }

        public async Task Persistir()
        {
            await _db.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
