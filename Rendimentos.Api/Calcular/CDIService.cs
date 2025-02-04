namespace Rendimentos.Api.Calcular;

public interface ICDIService
{
    decimal ObterCDI();
}

public class CDIService : ICDIService
{
    public decimal ObterCDI() => 0.009m;
}
