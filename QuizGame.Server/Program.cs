using Microsoft.EntityFrameworkCore;
using QuizGame.Server.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<QuizDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Devconnection")));

{

    var app = builder.Build();

    app.UseCors(options => options.WithOrigins("https://localhost:5173").AllowAnyMethod().AllowAnyHeader());

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}