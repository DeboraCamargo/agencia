using MrCasting.Domain.Entities;
using MrCasting.Domain.ValueObject;
using MrCasting.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace MrCasting.Infra.Data.Contexts
{
    public class GeneralContext : DbContext
    {
        public GeneralContext() : base("mrcastingbd")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<CaracteristicasFisicas> CaracteristicaFisica { get; set; }
        public DbSet<Hobby> Hobby { get; set; }
        public DbSet<Habilidade> Habilidade { get; set; }
        public DbSet<Interesse> Interesse { get; set; }
        public DbSet<Vaga> Vaga { get; set; }
        public DbSet<Proposta> Proposta { get; set; }
        public DbSet<Scouter> Scouter { get; set; }
        public DbSet<FotoObj> Foto { get; set; }
        public DbSet<VideoObj> Video { get; set; }
        public DbSet<LoginOAuth> LoginOAuth { get; set; }
        public DbSet<Conta> Conta { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new CandidatoConfiguration());
            modelBuilder.Configurations.Add(new CaracteristicasFisicasConfiguration());
            modelBuilder.Configurations.Add(new ContatoConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());
            modelBuilder.Configurations.Add(new PessoaConfiguration());
            modelBuilder.Configurations.Add(new TagConfiguration());
            modelBuilder.Configurations.Add(new HabilidadeConfiguration());
            modelBuilder.Configurations.Add(new HobbyConfiguration());
            modelBuilder.Configurations.Add(new InteresseConfiguration());
            modelBuilder.Configurations.Add(new FotoConfiguration());
            modelBuilder.Configurations.Add(new VideoConfiguration());
            modelBuilder.Configurations.Add(new VagaConfiguration());
            modelBuilder.Configurations.Add(new PropostaConfiguration());
            modelBuilder.Configurations.Add(new ScouterConfiguration());
            modelBuilder.Configurations.Add(new LoginOAuthConfiguration());

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<GeneralContext, Configuration>());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DtInclusao").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DtInclusao").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
