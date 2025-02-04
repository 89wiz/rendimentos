using Rendimentos.Api.Common;

namespace Rendimentos.Api.Calcular;

public interface ICalcularService
{
    ErrorOr<CalcularResponse> CalcularRendimentos(CalcularRequest request);
    decimal ObterTaxaRendimento();
    decimal CalcularValorFinal(decimal valor, int meses, decimal taxaRendimento);
    decimal CalcularImposto(decimal rendimento, int meses);
}

public class CalcularService(IImpostoService impostoService, ICDIService cdiService, ITBService tbService) : ICalcularService
{
    private readonly IImpostoService impostoService = impostoService;
    private readonly ICDIService cdiService = cdiService;
    private readonly ITBService tbService = tbService;

    public ErrorOr<CalcularResponse> CalcularRendimentos(CalcularRequest request)
    {
        if (request.Valor <= 0)
            return new ErrorOr<CalcularResponse>("Valor deve ser positivo");

        if (request.Meses <= 0)
            return new ErrorOr<CalcularResponse>("Meses deve ser positivo");

        var taxaRendimento = ObterTaxaRendimento();

        var valorFinal = CalcularValorFinal(request.Valor, request.Meses, taxaRendimento);
        var imposto = CalcularImposto(valorFinal - request.Valor, request.Meses);

        return new CalcularResponse { 
            TotalBruto = valorFinal,
            TotalLiquido = valorFinal - imposto,
            Deducoes = imposto,
            RendimentoBruto = valorFinal - request.Valor,
            RendimentoLiquido = valorFinal - request.Valor - imposto,
        };
    }

    public decimal CalcularValorFinal(decimal valor, int meses, decimal taxaRendimento)
    {
        var count = 0;
        var valorFinal = valor;

        while (count < meses)
        {
            valorFinal *= 1 + taxaRendimento;

            count++;
        }

        return valorFinal;
    }

    public decimal CalcularImposto(decimal rendimento, int meses)
    {
        var imposto = impostoService.ObterImposto(meses);

        return rendimento * imposto;
    }

    public decimal ObterTaxaRendimento()
    {
        var cdi = cdiService.ObterCDI();
        var tb = tbService.ObterTB();

        return cdi * tb;
    }
}
