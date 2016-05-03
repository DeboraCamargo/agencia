using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.DTO
{
   public class VideoDTO
    {
        public string Video { get; set; }

        public string NomeVideo { get; set; }

        public virtual  DateTime DataCriacao { get; set; }

        public int IdCandidato { get; set; }

        public int Id { get; set; }


    }
}
