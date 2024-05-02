using impromed_client;
using Impromed_Service;
using FileDiffLibrary;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddTransient<Service1>();
var host = builder.Build();
host.Run();