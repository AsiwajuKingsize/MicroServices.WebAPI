using Ocelot.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("ocelot.json");
builder.Services.AddOcelot();
var app = builder.Build();

//app.Use
app.MapGet("/", () => "Hello World!");

//app.UseMiddleware().

app.Run();
