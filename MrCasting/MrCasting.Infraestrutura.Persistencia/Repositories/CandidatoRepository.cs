using System;
using System.Collections.Generic;
using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Contexts;
using System.Data.Entity;
using System.Linq;
using MrCasting.Domain.DTO;
using MrCasting.Domain.DTO.Pesquisas;
using MrCasting.Domain.Exceptions;

namespace MrCasting.Infra.Data.Repositories
{
    public class CandidatoRepository : RepositoryBase<Candidato>, ICandidatoRepository
    {
        protected readonly DbSet<Candidato> CandidatoDb;

        public CandidatoRepository(GeneralContext context) : base(context)
        {
            CandidatoDb = context.Candidatos;
        }

        public override Candidato GetById(int id)
        {
            return GetCandidatoCompletoDb().Where(c => c.Id == id).FirstOrDefault();
        }

        private System.Data.Entity.Infrastructure.DbQuery<Candidato> GetCandidatoCompletoDb()
        {
            return CandidatoDb
                            .Include("DadosPessoais.Endereco")
                            .Include("DadosPessoais.Contato")
                            .Include("Hobby")
                            .Include("CaracteristicaFisica")
                            .Include("Habilidade")
                            .Include("Interesse");
        }

        public List<Candidato> ListarCandidatosPorNome(string nome)
        {
            return GetCandidatoCompletoDb().Where(c => c.DadosPessoais.Nome.Equals(nome)).ToList();
        }

        public void CadastrarCandidato(Candidato candidato)
        {
            Add(candidato);
            Commit();
        }

        public IEnumerable<Candidato> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais)
        {
            return CandidatoDb
                .Include("CaracteristicaFisica")
                .Include("DadosPessoais")
                .Where(c => c.DadosPessoais.Sexo == pesquisaDadosPessoais.Sexo);
        }

        public void EditarCandidato(Candidato candidato)
        {
            Update(candidato);
            Commit();
        }

        public IEnumerable<Candidato> PesquisarCompleto(PesquisaCandidatoDTO pesquisaDadosPessoais)
        {
            IQueryable<Candidato> filtro = GetCandidatoCompletoDb();
            
            #region Caracteristicas Fisicas

            if (pesquisaDadosPessoais.AlturaMaxima.HasValue)
            {
                filtro = filtro.Where(c => c.CaracteristicaFisica.Altura.HasValue && c.CaracteristicaFisica.Altura.Value <= pesquisaDadosPessoais.AlturaMaxima.Value);
            }

            if (pesquisaDadosPessoais.AlturaMinima.HasValue)
            {
                filtro = filtro.Where(c => c.CaracteristicaFisica.Altura.HasValue && c.CaracteristicaFisica.Altura.Value >= pesquisaDadosPessoais.AlturaMinima.Value);
            }

            if (pesquisaDadosPessoais.BustoMaximo.HasValue)
            {
                filtro = filtro.Where(c => c.CaracteristicaFisica.Busto.HasValue && c.CaracteristicaFisica.Busto.Value <= pesquisaDadosPessoais.BustoMaximo.Value);
            }

            if (pesquisaDadosPessoais.BustoMinimo.HasValue)
            {
                filtro = filtro.Where(c => c.CaracteristicaFisica.Busto.HasValue && c.CaracteristicaFisica.Busto.Value >= pesquisaDadosPessoais.BustoMinimo.Value);
            }

            if (!string.IsNullOrWhiteSpace(pesquisaDadosPessoais.Camisa))
            {
                filtro = filtro.Where(c => c.CaracteristicaFisica.Camisa.Equals(pesquisaDadosPessoais.Camisa));
            }

            if (pesquisaDadosPessoais.CinturaMaximo.HasValue)
            {
                filtro = filtro.Where(c => c.CaracteristicaFisica.Cintura.HasValue && c.CaracteristicaFisica.Cintura.Value <= pesquisaDadosPessoais.CinturaMaximo.Value);
            }

            if (pesquisaDadosPessoais.CinturaMinimo.HasValue)
            {
                filtro = filtro.Where(c => c.CaracteristicaFisica.Cintura.HasValue && c.CaracteristicaFisica.Cintura.Value >= pesquisaDadosPessoais.CinturaMinimo.Value);
            }

            if (!string.IsNullOrWhiteSpace(pesquisaDadosPessoais.ComprimentoCabelo))
            {
                filtro = filtro.Where(c => c.CaracteristicaFisica.ComprimentoCabelo.Equals(pesquisaDadosPessoais.ComprimentoCabelo));
            }

            if (!string.IsNullOrWhiteSpace(pesquisaDadosPessoais.CorDaPele))
            {
                filtro = filtro.Where(c => c.CaracteristicaFisica.CorPele.Equals(pesquisaDadosPessoais.CorDaPele));
            }

            if (!string.IsNullOrWhiteSpace(pesquisaDadosPessoais.CorDosOlhos))
            {
                filtro = filtro.Where(c => c.CaracteristicaFisica.CorOlhos.Equals(pesquisaDadosPessoais.CorDosOlhos));
            }

            if (!string.IsNullOrWhiteSpace(pesquisaDadosPessoais.Descendencia))
            {
                filtro = filtro.Where(c => c.CaracteristicaFisica.Descendencia.Contains(pesquisaDadosPessoais.Descendencia));
            }

            if (!string.IsNullOrWhiteSpace(pesquisaDadosPessoais.Etnia))
            {
                filtro = filtro.Where(c => c.CaracteristicaFisica.Etnia.Contains(pesquisaDadosPessoais.Etnia));
            }

            if (pesquisaDadosPessoais.ManequimMaximo.HasValue)
            {
                filtro = filtro.Where(x => x.CaracteristicaFisica.Manequim.HasValue && x.CaracteristicaFisica.Manequim.Value <= pesquisaDadosPessoais.ManequimMaximo.Value);
            }

            if (pesquisaDadosPessoais.ManequimMinimo.HasValue)
            {
                filtro = filtro.Where(x => x.CaracteristicaFisica.Manequim.HasValue && x.CaracteristicaFisica.Manequim.Value >= pesquisaDadosPessoais.ManequimMinimo.Value);
            }

            if (pesquisaDadosPessoais.PesoMaximo.HasValue)
            {
                filtro = filtro.Where(x => x.CaracteristicaFisica.Peso.HasValue && x.CaracteristicaFisica.Peso.Value <= pesquisaDadosPessoais.PesoMaximo.Value);
            }

            if (pesquisaDadosPessoais.PesoMinimo.HasValue)
            {
                filtro = filtro.Where(x => x.CaracteristicaFisica.Peso.HasValue && x.CaracteristicaFisica.Peso.Value >= pesquisaDadosPessoais.PesoMinimo.Value);
            }

            if (pesquisaDadosPessoais.QuadrilMaximo.HasValue)
            {
                filtro = filtro.Where(x => x.CaracteristicaFisica.Quadril.HasValue && x.CaracteristicaFisica.Quadril.Value <= pesquisaDadosPessoais.QuadrilMaximo.Value);
            }

            if (pesquisaDadosPessoais.QuadrilMinimo.HasValue)
            {
                filtro = filtro.Where(x => x.CaracteristicaFisica.Quadril.HasValue && x.CaracteristicaFisica.Quadril.Value >= pesquisaDadosPessoais.QuadrilMinimo.Value);
            }

            if (pesquisaDadosPessoais.SapatoMaximo.HasValue)
            {
                filtro = filtro.Where(x => x.CaracteristicaFisica.Sapato.HasValue && x.CaracteristicaFisica.Sapato.Value <= pesquisaDadosPessoais.SapatoMaximo.Value);
            }

            if (pesquisaDadosPessoais.SapatoMinimo.HasValue)
            {
                filtro = filtro.Where(x => x.CaracteristicaFisica.Sapato.HasValue && x.CaracteristicaFisica.Sapato.Value >= pesquisaDadosPessoais.SapatoMinimo.Value);
            }

            if (!string.IsNullOrWhiteSpace(pesquisaDadosPessoais.Terno))
            {
                filtro = filtro.Where(c => c.CaracteristicaFisica.Terno.Equals(pesquisaDadosPessoais.Terno));
            }

            if (!string.IsNullOrWhiteSpace(pesquisaDadosPessoais.TipoCabelo))
            {
                filtro = filtro.Where(c => c.CaracteristicaFisica.TipoCabelo.Equals(pesquisaDadosPessoais.TipoCabelo));
            }

            if (!string.IsNullOrWhiteSpace(pesquisaDadosPessoais.TipoFisico))
            {
                filtro = filtro.Where(c => c.CaracteristicaFisica.TipoFisico.Equals(pesquisaDadosPessoais.TipoFisico));
            }

            if (pesquisaDadosPessoais.ToraxMaximo.HasValue)
            {
                filtro = filtro.Where(x => x.CaracteristicaFisica.Torax.HasValue && x.CaracteristicaFisica.Torax.Value <= pesquisaDadosPessoais.ToraxMaximo.Value);
            }

            if (pesquisaDadosPessoais.ToraxMinimo.HasValue)
            {
                filtro = filtro.Where(x => x.CaracteristicaFisica.Torax.HasValue && x.CaracteristicaFisica.Torax.Value >= pesquisaDadosPessoais.ToraxMinimo.Value);
            }

            #endregion

            #region Dados Pessoais

            if (pesquisaDadosPessoais.IdadeMaxima.HasValue)
            {
                filtro = filtro.Where(x => x.DadosPessoais.DataNascimento.AddYears(pesquisaDadosPessoais.IdadeMaxima.Value) >= DateTime.Now);
            }

            if (pesquisaDadosPessoais.IdadeMinima.HasValue)
            {
                filtro = filtro.Where(x => x.DadosPessoais.DataNascimento.AddYears(pesquisaDadosPessoais.IdadeMinima.Value) <= DateTime.Now);
            }

            if (pesquisaDadosPessoais.Sexo.HasValue)
            {
                filtro = filtro.Where(c => c.DadosPessoais.Sexo == pesquisaDadosPessoais.Sexo.Value);
            }

            #endregion

            #region Candidato

            if (!string.IsNullOrWhiteSpace(pesquisaDadosPessoais.Nacionalidade))
            {
                filtro = filtro.Where(c => c.Nacionalidade.Contains(pesquisaDadosPessoais.Nacionalidade));
            }

            if (!string.IsNullOrWhiteSpace(pesquisaDadosPessoais.Naturalidade))
            {
                filtro = filtro.Where(c => c.Naturalidade.Contains(pesquisaDadosPessoais.Naturalidade));
            }

            if (!string.IsNullOrWhiteSpace(pesquisaDadosPessoais.Profissao))
            {
                filtro = filtro.Where(c => c.Profissao.Contains(pesquisaDadosPessoais.Profissao));
            }

            #endregion

            return filtro.ToList();
        }

        public void EditarCandidato(int idCandidato, Candidato candidato)
        {
            Candidato cand = CandidatoDb.Where(c => c.Id == idCandidato).FirstOrDefault();
            if (cand == null)
                throw new CandidatoNaoEncontradoException();

            cand.DRT = candidato.DRT;
            cand.Nacionalidade = candidato.Nacionalidade;
            cand.Naturalidade = candidato.Naturalidade;
            cand.NomeFantasia = candidato.NomeFantasia;
            cand.Profissao = candidato.Profissao;
            cand.Realise = candidato.Realise;
            Update(cand);
            Commit();
        }
    }
}
