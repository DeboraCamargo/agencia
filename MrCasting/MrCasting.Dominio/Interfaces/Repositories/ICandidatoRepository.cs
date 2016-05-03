using MrCasting.Domain.Entities;
using System.Collections.Generic;
using MrCasting.Domain.DTO;
using MrCasting.Domain.DTO.Pesquisas;

namespace MrCasting.Domain.Interfaces.Repositories
{
    public interface ICandidatoRepository : IRepository<Candidato>
    {
        void CadastrarCandidato(Candidato candidato);
        void EditarCandidato(int idCandidato, Candidato candidato);

        IEnumerable<Candidato> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais);
        IEnumerable<Candidato> PesquisarCompleto(PesquisaCandidatoDTO pesquisaDadosPessoais);
    }
}
