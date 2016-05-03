using MrCasting.Domain.Entities;
using MrCasting.Domain.Exceptions;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Infra.Data.Repositories
{
    public class VagaRepository : RepositoryBase<Vaga>, IVagaRepository
    {

        protected readonly DbSet<Vaga> VagaDb;
        protected readonly DbSet<Scouter> ScouterDb;

        private readonly ScouterRepository scouterRepository;

        public VagaRepository(GeneralContext context) : base(context)
        {
            VagaDb = context.Vaga;
            ScouterDb = context.Scouter;
            scouterRepository = new ScouterRepository(context);
        }

        public void CadastrarVaga(Vaga vaga)
        {
            VagaDb.Add(vaga);
            Commit();
        }

        public IEnumerable<string> ConsultarTodasVagasPorScouter(int idScouter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> ConsultarVagas(int idVaga)
        {
            throw new NotImplementedException();
        }

        public void EditarVaga(int idVaga, Vaga vaga)
        {
            Vaga vag = VagaDb.Where(c => c.Id == idVaga).FirstOrDefault();

            if (vag == null)
            {
                throw new VagaNaoEncontradaException();
            }

            vag.DescricaoVaga = vaga.DescricaoVaga;
            vag.TituloVaga = vaga.TituloVaga;
            vag.Status = vaga.Status;
            Update(vag);
            Commit();
        }


        public void RemoverVaga(int idVaga)
        {
        }
    }
}
