using MrCasting.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Entities
{
    public class Contato : EntityBase
    {
        #region Construtores

        protected Contato() { }

        public Contato(Email email, Telefone telefone)
        {
            SetEmail(email);
            SetTelefone(telefone);
        }

        #endregion

        #region Propriedades
        public Email Email { get; private set; }
        public Telefone Telefone { get; private set; }

        #endregion

        #region Regras de negocio

        public void SetEmail(Email email)
        {
            if (email == null)
                throw new Exception("E-mail Obrigatório");
            Email = email;
        }

        public void SetTelefone(Telefone telefone)
        {
            if (telefone == null)
                throw new Exception("Telefone Obrigatório");
            this.Telefone = telefone;
        }
        #endregion
    }
}
