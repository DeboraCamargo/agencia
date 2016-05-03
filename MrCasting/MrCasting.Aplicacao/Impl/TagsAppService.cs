using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.Interfaces.Services;
using MrCasting.Domain.ValueObject;
using System;
using System.Collections.Generic;

namespace MrCasting.Application.Impl
{
    public class TagsAppService : AppServiceBase<Tags>, ITagsAppService
    {
        private readonly ITagsService _service;
        ITagsService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("TagsService não pode ser nulo");
                return _service;
            }
        }

        public TagsAppService(ITagsService service) : base(service)
        {
            _service = service;
        }

        public void CadastrarTags(Tags tags)
        {
            Service.CadastrarTags(tags);
        }

        public void EditarTags(int idCandidato, List<Tags> tags)
        {
            Service.EditarTags(idCandidato, tags);

        }
    }
}