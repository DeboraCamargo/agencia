using MrCasting.Domain.Enuns;

namespace MrCasting.Domain.Entities
{
    public class Conta : EntityBase
    {
        public Conta() { }

        public Conta(LoginOAuth login, Scouter scouter)
        {
            this.Login = login;
            this.Scouter = scouter;
            Tipo = TipoConta.Scouter;
        }

        public Conta(LoginOAuth login, Candidato candidato)
        {
            this.Login = login;
            this.Candidato = candidato;
            Tipo = TipoConta.Candidato;
        }

        public LoginOAuth Login { get; set; }
        public Candidato Candidato { get; set; }
        public Scouter Scouter { get; set; }
        public TipoConta Tipo { get; set; }
    }
}
