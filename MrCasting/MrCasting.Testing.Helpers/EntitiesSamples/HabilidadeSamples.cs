using MrCasting.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
   public class HabilidadeSamples
    {
        public static HabilidadeDTO CriarHabilidadeDTO()
        {
            return new HabilidadeDTO()
            {
                NomeHabilidade = "nome  habilidade test",
            };
        }
    }
}
