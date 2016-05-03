using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrCasting.Domain.DTO;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
    public class LoginSamples
    {
        public const string EMAIL = "me.imagine.debby@gmail.com";

        public static LoginOAuth CreateLogin()
        {
            return CreateLogin(1);
        }

        public static LoginOAuth CreateLogin(int id)
        {
            return new LoginOAuth(EMAIL);
        }

        internal static LoginOAuthDTO CreateLoginDTO()
        {
            return new LoginOAuthDTO() { Email = EMAIL };
        }
    }
}
