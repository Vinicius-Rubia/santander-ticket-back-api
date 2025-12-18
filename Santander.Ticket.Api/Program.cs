using Santander.Ticket.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCustomServices(builder.Configuration)
    .AddUseCors();

var app = builder.Build();

app.UseCors("AllowAll");

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
