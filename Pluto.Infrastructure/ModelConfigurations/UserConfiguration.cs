using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pluto.Model.Entities;

namespace Pluto.Infrastructure.ModelConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.UserName).IsUnique();
            builder.HasOne(x => x.Role).WithMany(r => r.Users).HasForeignKey(x => x.FkRole);
        }
    }
}
