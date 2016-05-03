using MrCasting.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
   public class PropostaSamples
    {
        public static PropostaDTO CriarPropostaDTO(int id)
        {
            return new PropostaDTO()
            {
                Cache = 7000,
                DataEntrevista = new DateTime(2015, 04, 03),
                DataExpiraProposta = new DateTime (2015,05,03),
                DataFimJob = new DateTime(2015,12,03),
                DataIncioJob=new DateTime(2015,10,03),
                DetalhesProposta="Para vir filmar em Hollywood com passagem paga e"+ 
                "lazer para a familia inteira garantido enquando você faz seu trabalho",
                NaoTemFinalDataDefinida = false,
                vaga = VagaSamples.CriarVagaDTO(1),
                Status = Domain.Enuns.StatusPropostaEnum.Ativa

            };
        }
    }
}
