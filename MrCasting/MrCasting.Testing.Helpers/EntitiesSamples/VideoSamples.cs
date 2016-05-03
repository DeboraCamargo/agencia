using MrCasting.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
    public class VideoSamples
    {
        public static VideoDTO CriarVideoDTO()
        {
            return new VideoDTO()
            {
                Video = "https://www.youtube.com/watch?v=wy7inFeAKCY",
                NomeVideo = "Teste1"
            };
        }
    }
}

