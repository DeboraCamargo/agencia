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
    public class HobbyRepository : RepositoryBase<Hobby>, IHobbyRepository
    {

        private readonly DbSet<Hobby> HobbyDb;
        protected readonly DbSet<Candidato> CandidatoDb;
        private readonly CandidatoRepository candidatoRepository;

        public HobbyRepository(GeneralContext context) : base(context)
        {
            HobbyDb = context.Hobby;
            CandidatoDb = context.Candidatos;
            candidatoRepository = new CandidatoRepository(context);
        }

        public void CadastrarHobby(Hobby hobby)
        {
            Candidato candidato = candidatoRepository.GetById(hobby.IdCandidato);
            candidato.Hobby.Add(hobby);
            candidatoRepository.Update(candidato);
            candidatoRepository.Commit();
        }

        public void EditarHobby(int idCandidato, List<Hobby> hobby)
        {
            Candidato candidato = CandidatoDb.Where(c => c.Id == idCandidato).Include("Hobby").FirstOrDefault();
            if (candidato == null)
                throw new CandidatoNaoEncontradoException();

            List<Hobby> hobb = candidato.Hobby.ToList();
            candidato.Hobby.RemoveAll(h => true);

            DeleteAll(hobb);
            Commit();

            candidato.Hobby.AddRange(hobby);
            candidatoRepository.Update(candidato); // É algo assim
            candidatoRepository.Commit();
        }
    }
}
