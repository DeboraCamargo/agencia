using MrCasting.Domain.Entities;
using MrCasting.Domain.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.DTO
{
   public class PropostaDTO
    {
        public int id { get; set; }
        public virtual VagaDTO vaga { get; set; }
        public virtual double Cache { get; set; }
        public virtual DateTime DataEntrevista { get; set; }
        public virtual DateTime DataIncioJob { get; set; }
        public virtual DateTime DataFimJob { get; set; }
        public virtual DateTime DataExpiraProposta { get; set; }
        public virtual bool NaoTemFinalDataDefinida { get; set; }
        public string DetalhesProposta { get; set; }
        public StatusPropostaEnum Status { get; set; }
    }
}
