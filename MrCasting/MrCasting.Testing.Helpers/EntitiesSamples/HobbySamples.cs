using MrCasting.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
    public class HobbySamples
    {
        public static HobbyDTO CriarHobbyDTO()
        {
            return new HobbyDTO()
            {
                NomeHobby = "Malabarismo"
            };
        }
    }
}
    

