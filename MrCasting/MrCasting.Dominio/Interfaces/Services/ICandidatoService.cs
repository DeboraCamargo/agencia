using MrCasting.Domain.Entities;
using System.Collections.Generic;
using MrCasting.Domain.DTO;
using MrCasting.Domain.DTO.Pesquisas;

namespace MrCasting.Domain.Interfaces.Services
{
    public interface ICandidatoService : IServiceBase<Candidato>
    {
        void CadastrarCandidato(Candidato candidato);
        void EditarCandidato(int idCandidato, Candidato candidato);

        IEnumerable<Candidato> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais);
        IEnumerable<Candidato> PerqusarCompleto(PesquisaCandidatoDTO pesquisaDadosPessoais);
    }
}
