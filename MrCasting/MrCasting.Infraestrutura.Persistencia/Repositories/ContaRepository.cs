using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Contexts;
using System.Data.Entity;
using System.Linq;
using System;

namespace MrCasting.Infra.Data.Repositories
{
    public class ContaRepository : RepositoryBase<Conta>, IContaRepository
    {
        protected readonly DbSet<Conta> ContaDb;

        public ContaRepository(GeneralContext context) : base(context)
        {
            ContaDb = context.Conta;
        }

        public void CadastrarConta(Conta conta)
        {
            Add(conta);
            Commit();
        }

        public Conta GetByIdLogin(int idLogin)
        {
            return ContaDb.Where(c => c.Login.Id == idLogin)
                .Include("Login")
                .Include("Candidato.DadosPessoais.Contato")
                .Include("Candidato.DadosPessoais.Endereco")
                .Include("Candidato.CaracteristicaFisica")
                .Include("Candidato.Interesse")
                .Include("Candidato.Tags")
                .Include("Candidato.Hobby")
                .Include("Candidato.Habilidade")
                .FirstOrDefault();
        }

        public Conta GetByLogin(LoginOAuth login)
        {
            return ContaDb.Where(c => c.Login.Id == login.Id)
                .Include("Login")
                .Include("Candidato.DadosPessoais.Contato")
                .Include("Candidato.DadosPessoais.Endereco")
                .Include("Candidato.CaracteristicaFisica")
                .Include("Candidato.Interesse")
                .Include("Candidato.Tags")
                .Include("Candidato.Hobby")
                .Include("Candidato.Habilidade")
                .FirstOrDefault();
        }




    }
}