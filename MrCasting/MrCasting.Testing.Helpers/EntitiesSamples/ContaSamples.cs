using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
   public class ContaSamples
    {
        public static Conta CreateConta()
        {
            return CreateConta(1);
        }

        public static Conta CreateConta(int id)
        {
            return new Conta(LoginSamples.CreateLogin(),CandidatoSamples.CreateCandidatoMinimo(0)) ;
        }

        public static ContaDTO CreateContaDTO(int id)
        {
            return new ContaDTO() { Login = LoginSamples.CreateLoginDTO(),Candidato=CandidatoSamples.CreateCandidatoMinimoDTO(0)};
        }
    }
}
