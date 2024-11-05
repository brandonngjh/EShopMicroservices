var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Configre the HTTP request pipeline.

app.Run();
