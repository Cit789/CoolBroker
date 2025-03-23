using CoolBroker;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();

var app = builder.Build();
app.MapGrpcService<MainGrpcService>();
app.Run();