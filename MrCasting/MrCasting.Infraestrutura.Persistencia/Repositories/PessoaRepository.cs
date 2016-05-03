using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrCasting.Domain.Enuns;
using System.Data.Entity;
using MrCasting.Infra.Data.Contexts;

namespace MrCasting.Infra.Data.Repositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {

        private readonly DbSet<Pessoa> PessoaDb;
        private readonly CandidatoRepository candidatoRepository;


        public PessoaRepository(GeneralContext context) : base(context)
        {
            PessoaDb = context.Pessoas;
            candidatoRepository = new CandidatoRepository(context);

        }

        public List<Pessoa> ListarPessoaPorDataNascimento(DateTime data)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> ListarPessoaPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> ListarPessoaPorSexo(Genero sexo)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> ListarPessoaPorSobrenome(string sobrenome)
        {
            throw new NotImplementedException();
        }

        public void AtualizarPessoa(Pessoa pessoa)
        {
            Update(pessoa);
            Commit();
        }

        public void CadastrarPessoa(Pessoa pessoa)
        {
            Add(pessoa);
            Commit();
        }
    }
 }
