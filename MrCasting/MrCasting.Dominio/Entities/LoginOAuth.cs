namespace MrCasting.Domain.Entities
{
    public class LoginOAuth: EntityBase
    {
        protected LoginOAuth() { }

        public LoginOAuth(string email)
        {
            this.Email = email;
        }

        public string Email { get; set; }
        public string Token { get; set; }
    }
}
