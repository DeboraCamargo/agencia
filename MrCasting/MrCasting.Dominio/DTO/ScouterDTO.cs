using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.DTO
{
   public class ScouterDTO
    {

        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string Agencia { get; set; }
        public virtual PessoaDTO dadosPessoaisScouter { get; set; }
    }
}
