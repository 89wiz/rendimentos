namespace Rendimentos.Api.Calcular;

public interface ITBService
{
    decimal ObterTB();
}

public class TBService : ITBService
{
    public decimal ObterTB() => 1.08m;
}
