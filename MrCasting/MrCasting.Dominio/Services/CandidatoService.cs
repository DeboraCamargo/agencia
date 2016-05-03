using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using MrCasting.Domain.DTO;
using MrCasting.Domain.DTO.Pesquisas;

namespace MrCasting.Domain.Services
{
    public class CandidatoService : ServiceBase<Candidato>, ICandidatoService
    {
        private readonly ICandidatoRepository _repository;
        ICandidatoRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("CandidatoRepository não pode ser nulo");
                return _repository;
            }
        }

        public CandidatoService(ICandidatoRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public void CadastrarCandidato(Candidato candidato)
        {
            Repository.CadastrarCandidato(candidato);
        }

        public IEnumerable<Candidato> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais)
        {
            return Repository.PesquisarPorDadosPessoais(pesquisaDadosPessoais);
        }

        public IEnumerable<Candidato> PerqusarCompleto(PesquisaCandidatoDTO pesquisaDadosPessoais)
        {
            return Repository.PesquisarCompleto(pesquisaDadosPessoais);
        }

        public void EditarCandidato(int idCandidato, Candidato candidato)
        {
            Repository.EditarCandidato(idCandidato,candidato);

        }
    }
}
