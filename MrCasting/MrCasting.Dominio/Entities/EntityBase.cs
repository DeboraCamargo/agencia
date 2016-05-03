using System;

namespace MrCasting.Domain.Entities
{
    public abstract class EntityBase
    {

        public EntityBase()
        {
            this.DtInclusao = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime? DtAlteracao { get; set; }
    }
}
