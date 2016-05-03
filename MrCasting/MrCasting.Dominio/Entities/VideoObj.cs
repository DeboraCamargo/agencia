using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Entities
{
  public   class VideoObj : EntityBase
    {

        public VideoObj() { }

        public VideoObj(string video)
        {
            this.video = video;
        }

        public const int VideoMaxLenght = 255;
        private string video;

        public string Video
        {
            get { return video; }
            set { video = value; }
        }
        private string nomeVideo;

        public string NomeVideo
        {
            get { return nomeVideo; }
            set { nomeVideo = value; }
        }
        private DateTime dataCriacao;

        public DateTime DataCriacao
        {
            get { return dataCriacao; }
            set { dataCriacao = value; }
        }

        public int IdCandidato { get; set; }
        public virtual Candidato Candidato { get; set; }

    }
}
