using Database;
using Microsoft.EntityFrameworkCore;
using Database.repositories; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IIdeaRepository, IdeaRepository>();


string connectionString = builder.Configuration.GetConnectionString("TodoDb");
string password = Environment.GetEnvironmentVariable("SQL_SERVER_PASSWORD");
string username = Environment.GetEnvironmentVariable("SQL_SERVER_USERNAME");
connectionString = connectionString.Replace("{password}", password);
connectionString = connectionString.Replace("{username}", username);


builder.Services.AddDbContext<IdeaDatabaseContext>(options =>
{
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    options.UseSqlServer(connectionString, sqlServerOptions =>
        sqlServerOptions.MigrationsAssembly("Database"));
}, ServiceLifetime.Transient);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//Set port if defined in appsettings.json 
var port = builder.Configuration.GetValue<int>("Port");

if (port > 0)
{
    app.Run($"http://0.0.0.0:{port}");
}
else{
    app.Run();

}