using Microsoft.EntityFrameworkCore;
using Santander.Ticket.Domain.Entities;
using System.Reflection;
using TicketEntity = Santander.Ticket.Domain.Entities.Ticket;

namespace Santander.Ticket.Infrastructure.DataAccess;

internal class SantanderDbContext(DbContextOptions<SantanderDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<TicketEntity> Tickets { get; set; }
    public DbSet<TicketResponse> TicketResponses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}
