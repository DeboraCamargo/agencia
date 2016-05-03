using System;

namespace MrCasting.Domain.Entities
{
    public class FotoObj: EntityBase
    {

        public FotoObj() { }

        public FotoObj(byte[] foto) {
            this.foto = foto;
        }

        private byte[] foto;
        public byte[] Foto
        {
            get { return foto; }
            set { foto = value; }
        }
        private string nomeFoto;
        public string NomeFoto
        {
            get { return nomeFoto; }
            set { nomeFoto = value; }
        }
        private DateTime? dataCriacao;

        public DateTime? DataCriacao
        {
            get { return dataCriacao; }
            set { dataCriacao = value; }
        }

        public int IdCandidato { get; set; }
        public virtual Candidato Candidato { get; set; }

    }
}
