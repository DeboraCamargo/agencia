using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MrCasting.Helpers.Test
{
    [TestClass]
   public class GuardTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ForNullOrEmpty_Erro_Quando_Em_Branco()
        {
            Guard.ForNullOrEmpty("", "valor não pode ser vazio!");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ForNullOrEmpty_Erro_Quando_Null()
        {
            Guard.ForNullOrEmpty(null, "valor não pode ser vazio!");
        }
    }
}
