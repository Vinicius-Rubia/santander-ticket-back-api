using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Santander.Ticket.Domain.Entities;

namespace Santander.Ticket.Infrastructure.DataAccess.Mappings;

internal class UserMapping : BaseMapping<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);
        builder.ToTable("users");

        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(100);

        builder.Property(x => x.Email)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(150);

        builder.HasIndex(x => x.Email)
           .IsUnique();

        builder.Property(x => x.Password)
            .IsRequired()
            .HasColumnType("CHAR(60)");

        builder.Property(e => e.IsSantanderStaff)
            .HasDefaultValue(false)
            .IsRequired();
    }
}
