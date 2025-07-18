using Microsoft.EntityFrameworkCore;
using TestContainersExample.Endpoints;
using TestContainersExample.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


builder.Services.AddDbContext<ExamDbContext>(op => op
.UseSqlServer(builder.Configuration.GetConnectionString("ExamConnection"))
.EnableSensitiveDataLogging()
.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

builder.Services.AddScoped<IExamRepository, ExamRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapExamEndpoints();

app.Run();

public partial class Program { }
