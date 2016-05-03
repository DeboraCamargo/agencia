using MrCasting.Domain.Entities;
using MrCasting.Domain.Enuns;
using MrCasting.Domain.ValueObject;
using System;
using System.Data.Entity.Migrations;

namespace MrCasting.Infra.Data.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<MrCasting.Infra.Data.Contexts.GeneralContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MrCasting.Infra.Data.Contexts.GeneralContext context)
        {

            Pessoa debora = new Pessoa("Debora", "Barbosa Silva Camargo", new DateTime(1989, 01, 07), new Cpf("33550028873"), Genero.Feminino, new Contato(new Email("me.imagine.debby@gmail.com"), new Telefone("11", "985424740")));
            debora.Endereco = new Endereco("São Paulo", Uf.SP);
            Candidato candidataDebora = new Candidato(debora, "Debbylicious", new Interesse() { Ator = true })
            {
                Profissao = "CEO",
            };
            LoginOAuth loginDebora = new LoginOAuth("me.imagine.debby@gmail.com");
            Conta contaDebora = new Conta(loginDebora, candidataDebora);
            context.Conta.AddOrUpdate(contaDebora);
            
            //Pessoa alex = new Pessoa("Alex", "Carvalho Camargo", new DateTime(1983, 06, 20), new Cpf("31743357877"), Genero.Masculino, new Contato(new Email("alexccamargo@gmail.com"), new Telefone("11", "991400799")));
            //alex.Endereco = new Endereco("São Paulo", Uf.SP);
            //Candidato candidatoAlex = new Candidato(alex, "Arekê", new Interesse() { Figurante = true });
            //LoginOAuth loginAlex = new LoginOAuth("alexccamargo@gmail.com");
            //Conta contaAlex = new Conta(loginAlex, candidatoAlex);
            //context.Conta.AddOrUpdate(contaAlex);
        }
    }
}
