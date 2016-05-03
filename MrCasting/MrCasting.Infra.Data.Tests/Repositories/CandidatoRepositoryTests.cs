using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.Entities;
using MrCasting.Domain.ValueObject;
using MrCasting.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MrCasting.Infra.Data.Tests.Repositories
{
    [TestClass]
    public class CandidatoRepositoryTests
    {

        public CandidatoRepositoryTests()
        { }

        //Candidato candidatoTeste = new Candidato(10000, "Teste", new Email("teste@teste.com"), "Profissao Teste",DateTime.Now,null,null,null);

        [TestMethod]
        public void CandidatoRepository_AddCandidato()
        {
            //RepositoryList<Candidato> repository = new RepositoryList<Candidato>(GetCandidato());
            //int qtdAntes = repository.GetAll().Count();
            //repository.Add(candidatoTeste);
            //int qtdDepois = repository.GetAll().Count();

            //Assert.AreEqual(1, qtdDepois - qtdAntes);
        }

        private static List<Candidato>  GetCandidato()
        {
            List<Candidato> candidatos = new List<Candidato>();
            //candidatos.Add(new Candidato(1, "Candidato 1", new Email("Candidato1@teste.teste"), "Profissao 1", DateTime.Now,null,null,null));
            //candidatos.Add(new Candidato(2, "Candidato 2", new Email("Candidato2@teste.teste"), "Profissao 2", DateTime.Now, null, null, null));
            //candidatos.Add(new Candidato(3, "Candidato 3", new Email("Candidato3@teste.teste"), "Profissao 3", DateTime.Now, null, null, null));
            return candidatos;
        }

    }
}
