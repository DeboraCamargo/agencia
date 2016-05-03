using MrCasting.Domain.Entities;

namespace MrCasting.Domain.DTO
{
    public class ContatoDTO
    {
        #region Propriedades
        
        public string Email { get; set; }
        
        //public string DDD { get; set; }

        public string Telefone { get; set; }

        public int IdPessoa { get; set; }
        public PessoaDTO Pessoa { get; set; }

        #endregion

    }
}
