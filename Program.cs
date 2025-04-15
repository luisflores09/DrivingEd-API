using Microsoft.EntityFrameworkCore;
using DrivingEd_BackEnd.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration["DrivingEd-SqlDb"];

builder.Services.AddDbContext<DrivingEdDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.MapGet("/", () => "Welcome to DrivingEd App");

app.MapControllers();

app.Run();