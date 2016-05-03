using MrCasting.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Entities
{
    public class Hobby : EntityBase
    {

        public Hobby() { }

        public Hobby(string nomeHobby)
        {
            this.NomeHobby = nomeHobby;
        }

        public const int NomeHobbyMaxLenght = 30;
        public const int NomeHobbyMinLenght = 4;
        private string _nomeHobby;
        public string NomeHobby
        {
            get { return _nomeHobby; }
            set
            {
                _nomeHobby = value;
                ValidarNomeHobby();
            }
        }

        public int IdCandidato { get; set; }
        public virtual Candidato Candidato { get; set; }

    

        public void ValidarNomeHobby()
        {
            string nome = NomeHobby;

            Guard.ForNullOrEmpty(nome, "Nome não pode ser nulo ou vazio");
            Guard.ForSpecialCharacter(nome, "Nome não pode conter caracter especial");
            Guard.StringLength(nome, NomeHobbyMinLenght, NomeHobbyMaxLenght, "Fora do tamanho certo");

        }

      

    }
}
