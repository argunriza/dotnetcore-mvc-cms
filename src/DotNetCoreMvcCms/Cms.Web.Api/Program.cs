
using Cms.Data.DbContext;
using Cms.Data.Models.Entities;
using Cms.Services.Abstract;
using Cms.Services.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DbContext operations
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

//DI
builder.Services.AddScoped<DbContext, AppDbContext>();
builder.Services.AddScoped<IDataRepository<DoctorEntity>, DataRepository<DoctorEntity>>();
builder.Services.AddScoped<IDoctorService, DoctorService>();

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

using (var scope = app.Services.CreateScope())
{
	var services = scope.ServiceProvider;
	var context  = services.GetRequiredService<AppDbContext>();
	await context.Database.EnsureDeletedAsync();
	await context.Database.EnsureCreatedAsync();
}

app.Run();
