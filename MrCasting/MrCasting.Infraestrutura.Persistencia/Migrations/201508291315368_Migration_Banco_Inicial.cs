namespace MrCasting.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_Banco_Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidato",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrientacaoSexual = c.Int(),
                        DRT = c.String(maxLength: 100, unicode: false),
                        NomeFantasia = c.String(nullable: false, maxLength: 60, unicode: false),
                        SobrenomeFantasia = c.String(maxLength: 60, unicode: false),
                        Profissao = c.String(maxLength: 60, unicode: false),
                        Realise = c.String(maxLength: 1000, unicode: false),
                        Naturalidade = c.String(maxLength: 120, unicode: false),
                        Nacionalidade = c.String(maxLength: 120, unicode: false),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                        IdCaracteristicaFisica = c.Int(),
                        IdPessoa = c.Int(nullable: false),
                        IdInteresse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CaracteristicasFisicas", t => t.IdCaracteristicaFisica)
                .ForeignKey("dbo.Pessoa", t => t.IdPessoa)
                .ForeignKey("dbo.Interesse", t => t.IdInteresse)
                .Index(t => t.IdCaracteristicaFisica)
                .Index(t => t.IdPessoa)
                .Index(t => t.IdInteresse);
            
            CreateTable(
                "dbo.FotoObj",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Foto = c.Binary(nullable: false),
                        NomeFoto = c.String(maxLength: 100, unicode: false),
                        DataCriacao = c.DateTime(),
                        IdCandidato = c.Int(nullable: false),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidato", t => t.IdCandidato)
                .Index(t => t.IdCandidato);
            
            CreateTable(
                "dbo.VideoObj",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Video = c.String(nullable: false, maxLength: 255, unicode: false),
                        NomeVideo = c.String(maxLength: 100, unicode: false),
                        DataCriacao = c.DateTime(),
                        IdCandidato = c.Int(nullable: false),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidato", t => t.IdCandidato)
                .Index(t => t.IdCandidato);
            
            CreateTable(
                "dbo.CaracteristicasFisicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CorOlhos = c.String(maxLength: 20, unicode: false),
                        CorPele = c.String(maxLength: 20, unicode: false),
                        Manequim = c.Decimal(precision: 18, scale: 2),
                        Altura = c.Decimal(precision: 4, scale: 2),
                        Cintura = c.Decimal(precision: 4, scale: 2),
                        Busto = c.Decimal(precision: 4, scale: 2),
                        Quadril = c.Decimal(precision: 4, scale: 2),
                        Sapato = c.Decimal(precision: 18, scale: 2),
                        ComprimentoCabelo = c.String(maxLength: 30, unicode: false),
                        TipoCabelo = c.String(maxLength: 30, unicode: false),
                        Etnia = c.String(maxLength: 30, unicode: false),
                        Descendencia = c.String(maxLength: 60, unicode: false),
                        Peso = c.Decimal(precision: 5, scale: 2),
                        TipoFisico = c.String(maxLength: 30, unicode: false),
                        Terno = c.String(maxLength: 60, unicode: false),
                        Camisa = c.String(maxLength: 60, unicode: false),
                        Torax = c.Decimal(precision: 4, scale: 2),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cpf_Codigo = c.Long(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Sexo = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        SobreNome = c.String(nullable: false, maxLength: 120, unicode: false),
                        FotoPerfil = c.Binary(),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                        idContato = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contato", t => t.idContato)
                .Index(t => t.idContato);
            
            CreateTable(
                "dbo.Contato",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email_EnderecoDeEmail = c.String(nullable: false, maxLength: 254, unicode: false),
                        Telefone_Numero = c.String(nullable: false, maxLength: 100, unicode: false),
                        Telefone_DDD = c.String(nullable: false, maxLength: 100, unicode: false),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(maxLength: 80, unicode: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Numero = c.String(maxLength: 20, unicode: false),
                        Bairro = c.String(maxLength: 150, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 80, unicode: false),
                        Uf = c.Int(nullable: false),
                        CepValue = c.Long(),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                        Pessoa_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id);
            
            CreateTable(
                "dbo.Habilidade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeHabilidade = c.String(nullable: false, maxLength: 30, unicode: false),
                        IdCandidato = c.Int(nullable: false),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidato", t => t.IdCandidato)
                .Index(t => t.IdCandidato);
            
            CreateTable(
                "dbo.Hobby",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeHobby = c.String(nullable: false, maxLength: 30, unicode: false),
                        IdCandidato = c.Int(nullable: false),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidato", t => t.IdCandidato)
                .Index(t => t.IdCandidato);
            
            CreateTable(
                "dbo.Interesse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Modelo = c.Boolean(),
                        Ator = c.Boolean(),
                        ModeloPlusSize = c.Boolean(),
                        Figurante = c.Boolean(),
                        Evento = c.Boolean(),
                        Outros = c.Boolean(),
                        Mirin = c.Boolean(),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tag = c.String(nullable: false, maxLength: 30, unicode: false),
                        IdCandidato = c.Int(nullable: false),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidato", t => t.IdCandidato)
                .Index(t => t.IdCandidato);
            
            CreateTable(
                "dbo.Conta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.Int(nullable: false),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                        Candidato_Id = c.Int(),
                        Login_Id = c.Int(),
                        Scouter_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidato", t => t.Candidato_Id)
                .ForeignKey("dbo.LoginOAuth", t => t.Login_Id)
                .ForeignKey("dbo.Scouter", t => t.Scouter_Id)
                .Index(t => t.Candidato_Id)
                .Index(t => t.Login_Id)
                .Index(t => t.Scouter_Id);
            
            CreateTable(
                "dbo.LoginOAuth",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        Token = c.String(maxLength: 1000, unicode: false),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Scouter",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cnpj = c.String(nullable: false, maxLength: 100, unicode: false),
                        Agencia = c.String(maxLength: 100, unicode: false),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                        IdPessoa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.IdPessoa)
                .Index(t => t.IdPessoa);
            
            CreateTable(
                "dbo.Proposta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cache = c.Double(),
                        DataEntrevista = c.DateTime(nullable: false),
                        DataIncioJob = c.DateTime(),
                        DataFimJob = c.DateTime(),
                        DataExpiraProposta = c.DateTime(nullable: false),
                        NaoTemFinalDataDefinida = c.Boolean(),
                        DetalhesProposta = c.String(maxLength: 100, unicode: false),
                        Status = c.Int(),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                        IdVaga = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vaga", t => t.IdVaga)
                .Index(t => t.IdVaga);
            
            CreateTable(
                "dbo.Vaga",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TituloVaga = c.String(nullable: false, maxLength: 100, unicode: false),
                        DescricaoVaga = c.String(maxLength: 100, unicode: false),
                        Status = c.Int(),
                        DtInclusao = c.DateTime(nullable: false),
                        DtAlteracao = c.DateTime(),
                        IdScouter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Scouter", t => t.IdScouter)
                .Index(t => t.IdScouter);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Proposta", "IdVaga", "dbo.Vaga");
            DropForeignKey("dbo.Vaga", "IdScouter", "dbo.Scouter");
            DropForeignKey("dbo.Conta", "Scouter_Id", "dbo.Scouter");
            DropForeignKey("dbo.Scouter", "IdPessoa", "dbo.Pessoa");
            DropForeignKey("dbo.Conta", "Login_Id", "dbo.LoginOAuth");
            DropForeignKey("dbo.Conta", "Candidato_Id", "dbo.Candidato");
            DropForeignKey("dbo.Tags", "IdCandidato", "dbo.Candidato");
            DropForeignKey("dbo.Candidato", "IdInteresse", "dbo.Interesse");
            DropForeignKey("dbo.Hobby", "IdCandidato", "dbo.Candidato");
            DropForeignKey("dbo.Habilidade", "IdCandidato", "dbo.Candidato");
            DropForeignKey("dbo.Candidato", "IdPessoa", "dbo.Pessoa");
            DropForeignKey("dbo.Endereco", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Pessoa", "idContato", "dbo.Contato");
            DropForeignKey("dbo.Candidato", "IdCaracteristicaFisica", "dbo.CaracteristicasFisicas");
            DropForeignKey("dbo.VideoObj", "IdCandidato", "dbo.Candidato");
            DropForeignKey("dbo.FotoObj", "IdCandidato", "dbo.Candidato");
            DropIndex("dbo.Vaga", new[] { "IdScouter" });
            DropIndex("dbo.Proposta", new[] { "IdVaga" });
            DropIndex("dbo.Scouter", new[] { "IdPessoa" });
            DropIndex("dbo.Conta", new[] { "Scouter_Id" });
            DropIndex("dbo.Conta", new[] { "Login_Id" });
            DropIndex("dbo.Conta", new[] { "Candidato_Id" });
            DropIndex("dbo.Tags", new[] { "IdCandidato" });
            DropIndex("dbo.Hobby", new[] { "IdCandidato" });
            DropIndex("dbo.Habilidade", new[] { "IdCandidato" });
            DropIndex("dbo.Endereco", new[] { "Pessoa_Id" });
            DropIndex("dbo.Pessoa", new[] { "idContato" });
            DropIndex("dbo.VideoObj", new[] { "IdCandidato" });
            DropIndex("dbo.FotoObj", new[] { "IdCandidato" });
            DropIndex("dbo.Candidato", new[] { "IdInteresse" });
            DropIndex("dbo.Candidato", new[] { "IdPessoa" });
            DropIndex("dbo.Candidato", new[] { "IdCaracteristicaFisica" });
            DropTable("dbo.Vaga");
            DropTable("dbo.Proposta");
            DropTable("dbo.Scouter");
            DropTable("dbo.LoginOAuth");
            DropTable("dbo.Conta");
            DropTable("dbo.Tags");
            DropTable("dbo.Interesse");
            DropTable("dbo.Hobby");
            DropTable("dbo.Habilidade");
            DropTable("dbo.Endereco");
            DropTable("dbo.Contato");
            DropTable("dbo.Pessoa");
            DropTable("dbo.CaracteristicasFisicas");
            DropTable("dbo.VideoObj");
            DropTable("dbo.FotoObj");
            DropTable("dbo.Candidato");
        }
    }
}
