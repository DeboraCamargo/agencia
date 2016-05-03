using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrCasting.Domain.DTO;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
  public  class InteresseSamples
    {
        public static Interesse CreateInteresse()
        {
            return CreateInteresseAtor(1);
        }

        public static Interesse CreateInteresseAtor(int id)
        {
            return new Interesse() { Id = id, Ator = true };
        }

        public static Interesse CreateInteresseModelo(int id)
        {
            return new Interesse() { Id = id, Modelo = true };
        }

        public static Interesse CreateInteresseModeloPlusSize(int id)
        {
            return new Interesse() { Id = id, ModeloPlusSize = true };
        }

        public static Interesse CreateInteresseFigurante(int id)
        {
            return new Interesse() { Id = id, Figurante = true };
        }

        public static Interesse CreateInteresseEvento(int id)
        {
            return new Interesse() { Id = id, Evento = true };
        }

        public static Interesse CreateInteresseTodos(int id)
        {
            return new Interesse() { Id = id, Ator = true,Modelo =true, ModeloPlusSize = true, Evento =true, Figurante=true };
        }





        public static InteresseDTO CreateInteresseAtorDTO(int id)
        {
            return new InteresseDTO() { Id = id, Ator = true };
        }

        public static InteresseDTO CreateInteresseModeloDTO(int id)
        {
            return new InteresseDTO() { Id = id, Modelo = true };
        }

        public static InteresseDTO CreateInteresseModeloPlusSizeDTO(int id)
        {
            return new InteresseDTO() { Id = id, ModeloPlusSize = true };
        }

        public static InteresseDTO CreateInteresseFiguranteDTO(int id)
        {
            return new InteresseDTO() { Id = id, Figurante = true };
        }

        public static InteresseDTO CreateInteresseEventoDTO(int id)
        {
            return new InteresseDTO() { Id = id, Evento = true };
        }

        public static InteresseDTO CreateInteresseTodosDTO(int id)
        {
            return new InteresseDTO() { Id = id, Ator = true, Modelo = true, ModeloPlusSize = true, Evento = true, Figurante = true };
        }

    }
}
