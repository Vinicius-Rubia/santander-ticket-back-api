namespace Santander.Ticket.Domain.Entities;

public class User : BaseEntity
{
    public string Name { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
    public bool IsSantanderStaff { get; set; } = false;

    public ICollection<Ticket> Tickets { get; private set; } = [];
    public ICollection<TicketResponse> TicketResponses { get; private set; } = [];
}
