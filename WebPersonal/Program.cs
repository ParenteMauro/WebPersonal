using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.Server;
using Microsoft.EntityFrameworkCore;
using WebPersonal.BackEnd.src.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<WebPersonalDbContext>(options 
    => options.UseSqlServer(builder.Configuration.GetConnectionString("connectionDB")));
var app = builder.Build();
using (var scope = app.Services.CreateScope()) {
    DbContext context = scope.ServiceProvider.GetRequiredService<WebPersonalDbContext>();
    context.Database.Migrate();
};
app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();
