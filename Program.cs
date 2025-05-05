using Microsoft.EntityFrameworkCore;
using DrivingEd_BackEnd.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DrivingEd-SqlDb");
builder.Services.AddSqlServer<DrivingEdDbContext>(connectionString, options =>
    options.EnableRetryOnFailure());
    
// var connectionString = builder.Configuration["AZURE_SQL_CONNECTIONSTRING"];
// builder.Services.AddDbContext<DrivingEdDbContext>(options =>
//     options.UseSqlServer(connectionString));

builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();


app.MapGet("/", () => "Welcome to DrivingEd App");

app.MapControllers();

app.Run();