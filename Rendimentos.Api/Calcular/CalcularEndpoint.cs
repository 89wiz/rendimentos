namespace Rendimentos.Api.Calcular;

public static class CalcularEndpoint
{
    public static void Map(WebApplication app)
    {
        app.MapPost("/calcular", async (ICalcularService calcularService, CalcularRequest request) =>
        {
            return calcularService.CalcularRendimentos(request)
                .Match(
                    success => Results.Ok(success),
                    error => Results.BadRequest(error));
        });
    }
}

public class CalcularRequest
{
    public decimal Valor { get; set; }
    public int Meses { get; set; }
}

public class CalcularResponse
{
    public decimal TotalBruto { get; set; }
    public decimal TotalLiquido { get; set; }
    public decimal RendimentoBruto { get; set; }
    public decimal RendimentoLiquido { get; set; }
    public decimal Deducoes { get; set; }
}