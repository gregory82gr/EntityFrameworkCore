using EntityFrameworkCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options => 
{ 
    options.JsonSerializerOptions.ReferenceHandler= ReferenceHandler.IgnoreCycles;

});
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


var sqliteDatabaseName = builder.Configuration.GetConnectionString("SqLiteConnectionString");  
var folder = Environment.SpecialFolder.LocalApplicationData;
var path = Environment.GetFolderPath(folder);
var dbPath = Path.Join(path, sqliteDatabaseName);
var connectionString = $"Data Source={dbPath}";

builder.Services.AddDbContext<FootballLeageDbContext>(options =>
{
    options.UseSqlite($"Data Source={dbPath}")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .LogTo(Console.WriteLine, LogLevel.Information);  
                if (builder.Environment.IsDevelopment())
                {
                    options.EnableSensitiveDataLogging();
                    options.EnableDetailedErrors(); ;
                }
               
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
