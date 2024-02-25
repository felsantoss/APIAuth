using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo {Title = "API Auth", Description = "Create a API with JWT", Version = "v1"});
});

var app = builder.Build();

// Using swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Auth V1");
});

app.MapGet("/", () => "Hello World!");

app.Run();