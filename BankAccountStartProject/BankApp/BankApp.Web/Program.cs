using BankApp.Core.DataAccess;
using BankApp.Core.Features;
using BankApp.Core.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



// Dependencies:
// For more info see: https://scribe.nixnet.services/projectwt/simple-dependency-injection-in-net-6-0-web-api-24164e56f8f8
builder.Services.AddScoped<INotificationService, NotificationService>();

// TODO: In phase 2 you ill need to change this to your new IAccountRepository implementation
builder.Services.AddScoped<IAccountRepository, DbAccountRepository>();
builder.Services.AddScoped<PayInMoney>();
builder.Services.AddScoped<TransferMoney>();
builder.Services.AddScoped<WithdrawMoney>();






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
