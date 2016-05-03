using MrCasting.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Entities
{
    public class Habilidade : EntityBase
    {
        public Habilidade(string nomeHablidade)
        {
            this.NomeHabilidade = nomeHablidade;
        }

        public Habilidade () {}

        public const int NomeHabilidaeMaxlengh = 30;
        public const int NomeHabilidadeMinLengh = 4;
        private string _nomeHabilidade;
        public string NomeHabilidade
        {
            get { return _nomeHabilidade; }
            set { _nomeHabilidade = value;
                ValidarNomeHabilidade();
            }
        }

        public int IdCandidato { get; set; }
        public virtual Candidato Candidato { get; set; }

        public void ValidarNomeHabilidade()
        {
            string nome = NomeHabilidade;
            Guard.ForNullOrEmpty(nome, "Nome da habilidade não pode ser nulo ou vazio");
            Guard.ForNullOrWhiteSpace(nome, "Não pode ser nulo ou ser preenchido com espaços");
            Guard.ForSpecialCharacter(nome, "Nome da habilidade não pode conter caracteres especiais");
            Guard.StringLength(nome, NomeHabilidadeMinLengh, NomeHabilidaeMaxlengh, "Tamanho da habilidade fora do estipulado");

        }

    }
}
