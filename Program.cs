using fPOP_REST.Data;
using Scalar.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("FirePopDbContext") ?? throw new InvalidOperationException("Connection string 'FirePopDbContext' not found.");

builder.Services.AddDbContext<FirePopDbContext>(options => options.UseSqlServer(connectionString));


builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactNative", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
}

// app.MapScalarApiReference();
// app.MapOpenApi();
app.UseCors("AllowReactNative");
// app.UseHttpsRedirection();
app.UseRouting();


app.MapControllers();
app.Run();
