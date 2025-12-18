using Santander.Ticket.Domain.Enums;

namespace Santander.Ticket.Domain.Entities;

public class Ticket : BaseEntity
{
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public ETicketStatus Status { get; set; } = ETicketStatus.OPEN;
    public Guid UserId { get; set; }

    public User User { get; private set; } = null!;
    public ICollection<TicketResponse> TicketResponses { get; private set; } = [];
}
