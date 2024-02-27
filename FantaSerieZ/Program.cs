using Microsoft.EntityFrameworkCore;
using FantaSerieZ.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<PlayerManager>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("FantaSerieZTest")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    using(var scope = app.Services.CreateScope())
    {
        var playerManager = scope.ServiceProvider.GetRequiredService<PlayerManager>();
        playerManager.Database.EnsureCreated();
        playerManager.Seed();
    }
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting(); // Aggiunto per abilitare il routing

app.UseAuthorization(); // Assicurati di aggiungere questo se utilizzi l'autenticazione/autorizzazione

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // Aggiunto per mappare i controller
});

app.Run();

/* using Microsoft.EntityFrameworkCore;
using WebApiEntityFrameworkDockerSqlServer.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<SalesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FantaSerieZTest")));

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    var salesContext = scope.ServiceProvider.GetRequiredService<SalesContext>();
    salesContext.Database.EnsureCreated();
    salesContext.Seed();
}

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
 */