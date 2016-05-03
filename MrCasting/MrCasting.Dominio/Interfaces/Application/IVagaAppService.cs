﻿using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Interfaces.Application
{
   public interface IVagaAppService : IAppServiceBase<Vaga>
    {
        void CadastrarVaga(Vaga vaga);
        IEnumerable<string> ConsultarVagas(int idVaga);
        IEnumerable<string> ConsultarTodasVagasPorScouter(int idScouter);
        void RemoverVaga(int idVaga);
        void EditarVaga(int idvaga,Vaga vaga);
    }
}