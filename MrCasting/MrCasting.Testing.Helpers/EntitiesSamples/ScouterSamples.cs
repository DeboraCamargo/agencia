using MrCasting.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
    public class ScouterSamples
    {
        public static ScouterDTO CriaScouterDTO(int id)
        {
            return new ScouterDTO()
            {
                Agencia = "MrCasting",
                Cnpj = "14.644.419/0001-90",
                dadosPessoaisScouter = PessoaSamples.CreatePessoaDTO(),

            };
        }
    }
}
