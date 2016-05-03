using MrCasting.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MrCasting.Infra.Data.EntityConfig
{
    public class LoginOAuthConfiguration: EntityTypeConfiguration<LoginOAuth>
    {
        public LoginOAuthConfiguration()
        {
            HasKey(l => l.Id);

            Property(l => l.Email)
                .IsRequired();

            Property(l => l.Token)
                .IsOptional()
                .HasMaxLength(1000);
        }

    }
}
