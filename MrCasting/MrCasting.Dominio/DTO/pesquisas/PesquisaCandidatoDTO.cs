using MrCasting.Domain.Enuns;
using System.Collections.Generic;

namespace MrCasting.Domain.DTO.Pesquisas
{
    public class PesquisaCandidatoDTO
    {
        public int? IdadeMinima { get; set; }
        public int? IdadeMaxima { get; set; }

        public Genero? Sexo { get; set; }

        public List<string> Tags { get; set; }
        public List<string> Hobby { get; set; }
        public List<string> Habilitade { get; set; }
        public string Profissao { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }
        public InteresseDTO Interesse { get; set; }

        public string CorDosOlhos { get; set; }
        public string CorDaPele { get; set; }

        public decimal? ManequimMinimo { get; set; }
        public decimal? ManequimMaximo { get; set; }

        public decimal? AlturaMinima { get; set; }
        public decimal? AlturaMaxima { get; set; }

        public decimal? CinturaMinimo { get; set; }
        public decimal? CinturaMaximo { get; set; }

        public decimal? BustoMinimo { get; set; }
        public decimal? BustoMaximo { get; set; }

        public decimal? QuadrilMinimo { get; set; }
        public decimal? QuadrilMaximo { get; set; }

        public decimal? SapatoMinimo { get; set; }
        public decimal? SapatoMaximo { get; set; }

        public string ComprimentoCabelo { get; set; }

        public string TipoCabelo { get; set; }

        public string Etnia { get; set; }

        public string Descendencia { get; set; }

        public decimal? PesoMinimo { get; set; }
        public decimal? PesoMaximo { get; set; }

        public string TipoFisico { get; set; }

        public string Terno { get; set; }

        public string Camisa { get; set; }

        public decimal? ToraxMinimo { get; set; }
        public decimal? ToraxMaximo { get; set; }


    }
}
