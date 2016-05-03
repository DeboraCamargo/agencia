using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.Interfaces.Services;
using System;
using MrCasting.Domain.DTO;
using System.Collections.Generic;
using MrCasting.Domain.DTO.Pesquisas;

namespace MrCasting.Application.Impl
{
    public class CandidatoAppService : AppServiceBase<Candidato>, ICandidatoAppService
    {
        private readonly ICandidatoService _service;
        ICandidatoService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("CandidatoService não pode ser nulo");
                return _service;
            }
        }

        public CandidatoAppService(ICandidatoService service) : base(service)
        {
            _service = service;
        }

        public void CadastrarCandidato(Candidato candidato)
        {
            Service.CadastrarCandidato(candidato);
        }

        public IEnumerable<Candidato> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais)
        {
            return Service.PesquisarPorDadosPessoais(pesquisaDadosPessoais);
        }

        public void EditarCandidato(int idCandidato,Candidato candidato)
        {
            Service.EditarCandidato(idCandidato, candidato);
        }

        public IEnumerable<Candidato> PesquisarCompleta(PesquisaCandidatoDTO pesquisaDadosPessoais)
        {
            return Service.PerqusarCompleto(pesquisaDadosPessoais);
        }

     
    }
}
