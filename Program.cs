using fPOP_REST.Data;
using fPOP_REST.Utilities;
using Scalar.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("FirePopDbContext") ?? throw new InvalidOperationException("Connection string 'FirePopDbContext' not found.");

builder.Services.AddDbContext<fPOP_Context>(options => options.UseSqlServer(connectionString));


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

builder.Services.AddSingleton<ITmdbCacher, TmdbCacher>();
builder.Services.AddHostedService<TmdbStart>();

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

// var res = await TmdbCaller.GetTrendingMovies();
// Console.WriteLine(res);