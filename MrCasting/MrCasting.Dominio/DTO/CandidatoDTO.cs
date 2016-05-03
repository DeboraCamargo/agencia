using MrCasting.Domain.Enuns;
using System.Collections.Generic;

namespace MrCasting.Domain.DTO
{
    public class CandidatoDTO
    {
        #region Propriedades
        
        public int Id { get; set; }
        
        public PessoaDTO DadosPessoais { get; set; }

        public virtual List<FotoDTO> AlbumFotos { get; set; }

        public virtual List<VideoDTO> AlbumVideos { get; set; }

        public string Profissao { get; set; }
        
        public string Realise { get; set; }
        
        public string NomeFantasia { get; set; }
        
        public string SobrenomeFantasia { get;  set; }
        
        public CaracteristicasFisicasDTO CaracteristicaFisica { get; set; }

        public string Nacionalidade { get; set; }

        public string Naturalidade { get; set; }

        public List<TagsDTO> Tags { get; set; }

        public List<HobbyDTO> Hobby { get; set; }

        public List<HabilidadeDTO> Habilitade { get; set; }

        public InteresseDTO Interesse { get; set; }

        public string DRT { get; set; }

        public IdentidadeGenero OrientacaoSexual { get; set; }

        #endregion

        

    }
}