var builder = WebApplication.CreateBuilder(args);

// Add Services to the container
builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();

// Configure the HTTP request pipeline
app.MapReverseProxy();

app.Run();