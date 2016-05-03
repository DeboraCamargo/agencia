using MrCasting.Domain.DTO;
using MrCasting.Domain.DTO.Pesquisas;
using MrCasting.Domain.Entities;
using System.Collections.Generic;

namespace MrCasting.Domain.Interfaces.Application
{
    public interface ICandidatoAppService : IAppServiceBase<Candidato>
    {
        void CadastrarCandidato(Candidato candidato);
        void EditarCandidato(int idCandidato, Candidato candidato);

        IEnumerable<Candidato> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais);
        IEnumerable<Candidato> PesquisarCompleta(PesquisaCandidatoDTO pesquisaDadosPessoais);

    }
}
