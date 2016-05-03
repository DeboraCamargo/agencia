using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
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
    public class FotoRepository : RepositoryBase<FotoObj>, IFotoRepository
    {
        protected readonly DbSet<FotoObj> FotoDb;
        protected readonly DbSet<Candidato> CandidatoDb;
        private readonly CandidatoRepository candidatoRepository;

        public FotoRepository(GeneralContext context) : base(context)
        {
            FotoDb = context.Foto;
            CandidatoDb = context.Candidatos;
            candidatoRepository = new CandidatoRepository(context);
        }

        public void CadastrarFoto(FotoObj foto)
        {
            Add(foto);
            Commit();
        }

        public IEnumerable<FotoObj> ConsultarFotos(int idCandidato)
        {
            return FotoDb.Where(f => f.IdCandidato == idCandidato);
        }

        public void RemoverFoto(int idFoto)
        {
            FotoObj foto = FotoDb.Where(f => f.Id == idFoto).FirstOrDefault();
            if (foto == null)
                throw new Exception("Foto não encontrada");
            FotoDb.Remove(foto);
        }       
    }
}
