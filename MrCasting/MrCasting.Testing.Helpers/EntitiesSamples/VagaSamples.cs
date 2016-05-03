using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
   public class VagaSamples
    {

        public static VagaDTO CriarVagaDTO(int id)
        {
            return new VagaDTO()
            {
                DescricaoVaga = "Vaga para teste no samples",
                //Ainda não temos um scouter no banco,favor colocar senão vai dar Pau aqui, bjs Debborah
                ProprietarioVaga = ScouterSamples.CriaScouterDTO(1),
                TituloVaga = "Vaga para teste",
                Status = Domain.Enuns.StatusVagaEnum.Fechada

            };

        }
    }
}
