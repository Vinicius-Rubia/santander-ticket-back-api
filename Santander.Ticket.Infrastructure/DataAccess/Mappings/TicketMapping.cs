using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketEntity = Santander.Ticket.Domain.Entities.Ticket;

namespace Santander.Ticket.Infrastructure.DataAccess.Mappings;

internal class TicketMapping : BaseMapping<TicketEntity>
{
    public override void Configure(EntityTypeBuilder<TicketEntity> builder)
    {
        base.Configure(builder);
        builder.ToTable("tickets");

        builder.Property(x => x.Title)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(200);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnType("TEXT");

        builder.Property(x => x.Status)
           .IsRequired()
           .HasColumnType("INT");
    }
}