using System;

namespace MrCasting.Domain.DTO
{
    public class FotoDTO
    {
        public string Foto { get; set; }
       
        public string NomeFoto { get; set; }

        public virtual DateTime? DataCriacao { get; set; }

        public int IdCandidato { get; set; }

        public int Id { get; set; }

    }
}
