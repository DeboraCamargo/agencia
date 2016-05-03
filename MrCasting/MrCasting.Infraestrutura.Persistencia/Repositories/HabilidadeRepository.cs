using MrCasting.Domain.Entities;
using MrCasting.Domain.Exceptions;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MrCasting.Infra.Data.Repositories
{
    public class HabilidadeRepository : RepositoryBase<Habilidade>, IHabilidadeRepository
    {
        protected readonly DbSet<Habilidade> HabilidadeDb;
        protected readonly DbSet<Candidato> CandidatoDb;
        private readonly CandidatoRepository candidatoRepository;

        public HabilidadeRepository(GeneralContext context) : base(context)
        {
            HabilidadeDb = context.Habilidade;
            CandidatoDb = context.Candidatos;
            candidatoRepository = new CandidatoRepository(context);
        }

        public void CadastrarHabilidade(Habilidade habilidade)
        {
            Candidato candidato = candidatoRepository.GetById(habilidade.IdCandidato);
            candidato.Habilidade.Add(habilidade);
            candidatoRepository.Update(candidato);
            candidatoRepository.Commit();
        }

        public void EditarHabilidade(int idCandidato, List<Habilidade> habilidades)
        {
            Candidato candidato = CandidatoDb.Where(c => c.Id == idCandidato).Include("Habilidade").FirstOrDefault();
            if (candidato == null)
                throw new CandidatoNaoEncontradoException();

            List<Habilidade> habs = candidato.Habilidade.ToList();
            candidato.Habilidade.RemoveAll(h=> true);

            DeleteAll(habs);
            Commit();

            candidato.Habilidade.AddRange(habilidades);
            candidatoRepository.Update(candidato); // É algo assim
            candidatoRepository.Commit();
            
        }
    }

}
