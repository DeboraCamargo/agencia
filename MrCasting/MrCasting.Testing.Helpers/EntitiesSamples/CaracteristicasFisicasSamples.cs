using MrCasting.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
    public class CaracteristicasFisicasSamples
    {

        public static CaracteristicasFisicasDTO CriarCaracteristicaFisicaDTO()
        {
            return new CaracteristicasFisicasDTO()
            {
                Altura = 1.55m,
                Busto = 0.50m,
                Camisa = "Media",
                Cintura = 0.60m,
                ComprimentoCabelo = "Longo",
                CorOlhos = "Castanho",
                CorPele = "Preta",
                Descendencia = "AfroBrasileira",
                Etnia = "negra",
                Manequim = 42m,
                Peso = 72m,
                Quadril = 0.50m,
                Sapato = 35m,
                Terno = "Grande",
                TipoCabelo = "Crespo",
                TipoFisico = "Acima do Peso",
                Torax = 0.40m,
            };
        }
    }
}
