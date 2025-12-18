namespace Santander.Ticket.Domain.Entities;

public class TicketResponse : BaseEntity
{
    public Guid TicketId { get; set; }
    public Guid UserId { get; set; }
    public long Content { get; set; }
    public bool IsOfficialResponse { get; set; }

    public User User { get; private set; } = null!;
    public Ticket Ticket { get; private set; } = null!;
}
