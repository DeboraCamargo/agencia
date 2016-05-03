using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace MrCasting.Application.Impl
{
    public class FotoAppService : AppServiceBase<FotoObj>, IFotoAppService
    {
        private readonly IFotoService _service;
        IFotoService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("FotoService não pode ser nulo");
                return _service;
            }
        }

        public FotoAppService(IFotoService service) : base(service)
        {
            _service = service;
        }

        public IEnumerable<FotoObj> ConsultarFotos(int idcandidato)
        {
            return Service.ConsultarFotos(idcandidato);
        }

        public void RemoverFoto(int idFoto)
        {
            Service.RemoverFoto(idFoto);
        }

    
        public void CadastrarFoto(FotoObj fotoObj)
        {
            Service.CadastrarFoto(fotoObj);
        }
    }
}
