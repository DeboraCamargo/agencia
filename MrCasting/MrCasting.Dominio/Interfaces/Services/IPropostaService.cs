﻿using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Interfaces.Services
{
  public  interface IPropostaService : IServiceBase<Proposta>
    {
        void CadastrarProposta(Proposta proposta);
        IEnumerable<string> ConsultarPropostas(int idScouter);
        void RemoverProposta(int idProposta);
        void EditarProposta(int idProposta,Proposta proposta);
    }
}
