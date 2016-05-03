using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Contexts;
using System.Data.Entity;
using System;
using System.Linq;
using MrCasting.Domain.Exceptions;

namespace MrCasting.Infra.Data.Repositories
{
    public class CaracteristicaFisicaRepository : RepositoryBase<CaracteristicasFisicas>, ICaracteristicaFisicaRepository
    {
        protected readonly DbSet<CaracteristicasFisicas> CaracteristicaFisicaDb;
        protected readonly DbSet<Candidato> CandidatoDb;

        protected readonly CandidatoRepository CandidatoRepository;

        public CaracteristicaFisicaRepository(GeneralContext context) : base(context)
        {
            CaracteristicaFisicaDb = context.CaracteristicaFisica;
            CandidatoDb = context.Candidatos;
            CandidatoRepository = new CandidatoRepository(context);
        }

        public void CadastrarCaracteristicasFisicas(CaracteristicasFisicas caracteristicasFisicas)
        {
            throw new NotImplementedException();
        }

        public void EditarCaracteristicaFisica(int IdCandidato, CaracteristicasFisicas caracteristicasFisicas)
        {
            Candidato candidato = CandidatoDb.Where(c => c.Id == IdCandidato).Include("CaracteristicaFisica").FirstOrDefault();
            if (candidato == null)
                throw new CandidatoNaoEncontradoException();

            CaracteristicasFisicas cf = candidato.CaracteristicaFisica;
            if (cf == null)
            {
                candidato.CaracteristicaFisica = caracteristicasFisicas;
                CandidatoRepository.Update(candidato);
                Commit();
            }
            else
            {
                cf.Altura = caracteristicasFisicas.Altura;
                cf.Busto = caracteristicasFisicas.Busto;
                cf.Camisa = caracteristicasFisicas.Camisa;
                cf.Cintura = caracteristicasFisicas.Cintura;
                cf.ComprimentoCabelo = caracteristicasFisicas.ComprimentoCabelo;
                cf.CorOlhos = caracteristicasFisicas.CorOlhos;
                cf.CorPele = caracteristicasFisicas.CorPele;
                cf.Descendencia = caracteristicasFisicas.Descendencia;
                cf.Etnia = caracteristicasFisicas.Etnia;
                cf.Manequim = caracteristicasFisicas.Manequim;
                cf.Peso = caracteristicasFisicas.Peso;
                cf.Quadril = caracteristicasFisicas.Quadril;
                cf.Sapato = caracteristicasFisicas.Sapato;
                cf.Terno = caracteristicasFisicas.Terno;
                cf.TipoCabelo = caracteristicasFisicas.TipoCabelo;
                cf.TipoFisico = caracteristicasFisicas.TipoFisico;
                cf.Torax = caracteristicasFisicas.Torax;
                Update(cf);
                Commit();
            }
        }
    }
}
