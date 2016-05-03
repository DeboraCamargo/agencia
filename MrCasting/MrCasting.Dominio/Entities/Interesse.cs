namespace MrCasting.Domain.Entities
{
    public class Interesse: EntityBase
    {
        public Interesse() { }

        public virtual bool Modelo { get; set; }
        public virtual bool Ator { get; set; }
        public virtual bool ModeloPlusSize { get; set; }
        public virtual bool Figurante { get; set; }
        public virtual bool Evento { get; set; }
        public virtual bool Outros { get; set; }
        public virtual bool Mirin { get; set; }

    }
}
