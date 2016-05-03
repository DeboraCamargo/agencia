using MrCasting.Domain.Entities;
using MrCasting.Domain.Enuns;

namespace MrCasting.Domain.DTO
{
    public class EnderecoDTO
    {
        #region Propriedades

        public virtual int Id { get; set; }

        public int IdPessoa { get; set; }
        public virtual PessoaDTO Pessoa { get; set; }

        public virtual string Logradouro { get; set; }

        public virtual string Complemento { get; set; }

        public virtual string Numero { get; set; }

        public virtual string Bairro { get; set; }

        public virtual string Cidade { get; set; }

        public virtual Uf Uf { get; set; }

        public virtual string Cep { get; set; }
        #endregion

       
    }
}
