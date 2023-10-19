using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Persistence;
using VeterinaryApi.Extension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options => 
{
    options.RespectBrowserAcceptHeader = true;
    options.ReturnHttpNotAcceptable = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAplicacionServices();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureApiVersioning(); //version
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
builder.Services.ConfigureCors();

builder.Services.AddDbContext<VeterinaryContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("ConexMysql");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}   
app.UseCors("CorsPolicy");  

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
