using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.DTO
{
    public class InteresseDTO
    {
        public InteresseDTO() { }

        public bool Modelo { get; set; }
        public bool Ator { get; set; }
        public bool ModeloPlusSize { get; set; }
        public bool Figurante { get; set; }
        public bool Evento { get; set; }
        public bool Outros { get; set; }
        public bool Mirim { get; set; }
        public int Id { get; set; }

    }
}
