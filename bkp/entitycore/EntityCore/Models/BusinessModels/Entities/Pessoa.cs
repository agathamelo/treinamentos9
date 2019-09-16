using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCore.Models.BusinessModels.Entities
{
    public class Pessoa
    {
        public Pessoa()
        {
            this.Endereco = new HashSet<Endereco>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public virtual IEnumerable<Endereco> Endereco { get; set; }
    }
}
