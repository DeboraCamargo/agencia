using MrCasting.Domain.Entities;
using MrCasting.Helpers;

namespace MrCasting.Domain.ValueObject
{
    public class Tags : EntityBase
    {
        #region Modelo Antigo Tags
        /*public readonly char[] SEPARATOR = new char[] { '#' };

        List<string> _list;
        public List<string> List
        {
            get
            {
                return _list.ToList();
            }

            private set
            {
                _list = value;
            }
        }

        public Tags()
        {
            List = new List<string>();
        }

        public Tags(string tags) : this()
        {
            if (string.IsNullOrWhiteSpace(tags))
                throw new Exception("Tags não pode ser nula, vazia ou apenas espaços, utilize o construtor sem parametro para esses casos");
            Add(tags);
        }

        public void Add(string tag)
        {
            if (string.IsNullOrWhiteSpace(tag))
                throw new Exception("Não é possível adicionar tag nula ou vazia");
            if (tag.Contains(" "))
                _list.AddRange(tag.Split(SEPARATOR, StringSplitOptions.RemoveEmptyEntries));
            else
                _list.Add(tag);
        }

        public void Remove(string tag)
        {
            if(!_list.Remove(tag))
                throw new Exception("Tag não existente");
        }
        */
        #endregion

        public Tags() { }

        public Tags(string tag)
        {
            this.Tag = tag;
        }

        public const int TagMaxLenght = 30;
        public const int TagMinLenght = 2;
        private string _tag;
        public string Tag
        {
            get { return _tag; }
            set
            {
                _tag = value;
                ValidarTag();
            }
        }

        public int IdCandidato { get; set; }
        public virtual Candidato Candidato { get; set; }

        public void ValidarTag()
        {
            string tag = Tag;
            if (string.IsNullOrEmpty(tag))
                return;

            Guard.ForSpecialCharacter(tag, "Tag não pode conter caracter especial");
            Guard.StringLength(tag, TagMinLenght, TagMaxLenght, "Fora do tamanho certo");

        }
    }
}
