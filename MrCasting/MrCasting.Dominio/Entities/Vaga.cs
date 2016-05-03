using MrCasting.Domain.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Entities
{
     public class Vaga: EntityBase
    {
        public Vaga() { }

        public Vaga(int Id, string titulo, Scouter scouter) {
            this.Id = Id;
            this.ProprietarioVaga = scouter;
            this.TituloVaga = titulo;
            Status = StatusVagaEnum.Ativa;
        }

        public Vaga(string titulo, Scouter scouter)
        {
            this.ProprietarioVaga = scouter;
            this.TituloVaga = titulo;
            Status = StatusVagaEnum.Ativa;

        }

        public string TituloVaga { get; set; }
        public string DescricaoVaga { get; set; }
        public virtual Scouter ProprietarioVaga { get; set; }
        public StatusVagaEnum Status { get; set; }

    }
}
