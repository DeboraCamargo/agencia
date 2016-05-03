using MrCasting.Domain.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.DTO
{
  public  class ContaDTO
    {

        public int Id { get; set; }
        public LoginOAuthDTO Login { get; set; }
        public CandidatoDTO Candidato { get; set; }
        public ScouterDTO Scouter { get; set; }
        public TipoConta Tipo { get; set; }
    }
}
