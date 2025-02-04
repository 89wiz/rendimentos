using Rendimentos.Api.Calcular;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddOpenApi();
services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
{
    builder
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowAnyOrigin();
}));

services.AddSingleton<ICalcularService, CalcularService>();
services.AddSingleton<IImpostoService, ImpostoService>();
services.AddSingleton<ICDIService, CDIService>();
services.AddSingleton<ITBService, TBService>();

var app = builder.Build();

app.UseCors("CorsPolicy");

app.MapOpenApi();
app.MapScalarApiReference();

CalcularEndpoint.Map(app);

app.UseHttpsRedirection();
app.Run();