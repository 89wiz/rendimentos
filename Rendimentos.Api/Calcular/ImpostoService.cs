namespace Rendimentos.Api.Calcular;

public interface IImpostoService
{
    decimal ObterImposto(int meses);
}

public class ImpostoService : IImpostoService
{
    public decimal ObterImposto(int meses)
    {
        return meses switch
        {
            <= 6 => .225m,
            <= 12 => .20m,
            <= 24 => .175m,
            > 24 => .15m
        };
    }
}
