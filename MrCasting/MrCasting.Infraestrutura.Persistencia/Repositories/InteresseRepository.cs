using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Contexts;
using System.Data.Entity;
using System;
using System.Linq;
using MrCasting.Domain.Exceptions;

namespace MrCasting.Infra.Data.Repositories
{
    public class InteresseRepository : RepositoryBase<Interesse>, IInteresseRepository
    {
        private readonly DbSet<Interesse> InteresseDb;
        private readonly DbSet<Candidato> CandidatoDb;
        private readonly CandidatoRepository CandidatoRepository;

        public InteresseRepository(GeneralContext context) : base(context)
        {
            InteresseDb = context.Interesse;
            CandidatoDb = context.Candidatos;
            CandidatoRepository = new CandidatoRepository(context);
        }

        public void CadastrarInteresse(Interesse interesse)
        {
            InteresseDb.Add(interesse);
            Commit();
        }

        public void EditarInteresse(int IdCandidato, Interesse interesse)
        {
            Candidato candidato = CandidatoDb.Include("Interesse").Where(c => c.Id == IdCandidato).FirstOrDefault();
            if (candidato == null)
            {
                throw new CandidatoNaoEncontradoException();
            }

            if (candidato.Interesse == null)
            {
                candidato.Interesse = interesse;
            }
            else
            {
                candidato.Interesse.Ator = interesse.Ator;
                candidato.Interesse.Evento = interesse.Evento;
                candidato.Interesse.Figurante = interesse.Figurante;
                candidato.Interesse.Mirin = interesse.Mirin;
                candidato.Interesse.Modelo = interesse.Modelo;
                candidato.Interesse.ModeloPlusSize = interesse.ModeloPlusSize;
                candidato.Interesse.Outros = interesse.Outros;
            }

            CandidatoRepository.Update(candidato);
            CandidatoRepository.Commit();

        }
    }
}
