using MrCasting.Domain.Entities;
using MrCasting.Domain.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.DTO
{
   public class VagaDTO
    {
        public int Id { get; set; }
        public string TituloVaga { get; set; }
        public string DescricaoVaga { get; set; }
        public virtual ScouterDTO ProprietarioVaga { get; set; }
        public StatusVagaEnum Status { get; set; }

    }
}
