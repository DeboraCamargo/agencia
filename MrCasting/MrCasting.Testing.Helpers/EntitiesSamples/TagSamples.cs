using MrCasting.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
   public class TagSamples
    {
        public static TagsDTO CriarTagDTO()
        {
            return new TagsDTO()
            {
               Tag = "#Lindo #Brabeza #Preguiça #Fome #MandaFoods"
            };
        }
    }
}


