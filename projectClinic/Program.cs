using Clinic.Core.Services;
using projectClinic;
using Clinic.Core;
using Clinic.Data;
using Clinic.Core.Repositories;
using Clinic.Core.Entities;
using Clinic.Service;
using Clinic.Data.Repositories;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IClientsRepository, ClientRepository>();

builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddScoped<IDoctorsRepository, DoctorRepository>();

builder.Services.AddScoped<IQueueService, QueueService>();
builder.Services.AddScoped<IQueuesRepository, QueueRepository>();

builder.Services.AddDbContext<DataContext>();

builder.Services.AddAutoMapper(typeof(MappingProfile));


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
