using Microsoft.EntityFrameworkCore;
using StudentsAPI.Data;
using StudentsAPI.Repository;
using StudentsAPI.Repository.IRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add DbContext
builder.Services.AddDbContext<StudentsDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConStr")));

//Add DI
builder.Services.AddScoped<IStudentRepository, StudentRepository>(); 
builder.Services.AddScoped<IScoreRepository, ScoreRepository>();


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

app.Run();
