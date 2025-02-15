using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddApiVersioning();
var app = builder.Build();
app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();
