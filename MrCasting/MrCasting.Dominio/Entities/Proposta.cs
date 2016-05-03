using MrCasting.Domain.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Entities
{
   public class Proposta: EntityBase
    {
        protected Proposta() { }

        public Proposta(Vaga vaga, DateTime dataExpira, DateTime dataEntrevista)
        {
            this.Vaga = vaga;
            this.DataEntrevista = dataEntrevista;
            this.DataExpiraProposta = dataExpira;
            Status = StatusPropostaEnum.Ativa;
        }

        public virtual Vaga Vaga { get; set; }
        public virtual double Cache { get; set; }
        public virtual DateTime DataEntrevista { get; set; }
        public virtual DateTime DataIncioJob { get; set; }
        public virtual DateTime DataFimJob { get; set; }
        public virtual DateTime DataExpiraProposta { get; set; }
        public virtual bool NaoTemFinalDataDefinida { get; set; }
        public string DetalhesProposta { get; set; }
        public StatusPropostaEnum Status { get; set; }
        
        //Lembra de fazer a validação viceVersa
        //Data da inicio antes da data de fim
        //Data Expira depois da data de inicio
        //Data Expira antes da data fim
        //Data da entrevista depois da data Inicio, Antes da Data Expira

    }
}
