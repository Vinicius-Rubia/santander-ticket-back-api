using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Santander.Ticket.Domain.Entities;

namespace Santander.Ticket.Infrastructure.DataAccess.Mappings;

internal class TicketResponseMapping : BaseMapping<TicketResponse>
{
    public override void Configure(EntityTypeBuilder<TicketResponse> builder)
    {
        base.Configure(builder);
        builder.ToTable("ticket_responses");

        builder.Property(x => x.Content)
            .IsRequired()
            .HasColumnType("text");

        builder.Property(e => e.IsOfficialResponse)
            .HasDefaultValue(false);

        builder.HasIndex(e => e.TicketId);
    }
}