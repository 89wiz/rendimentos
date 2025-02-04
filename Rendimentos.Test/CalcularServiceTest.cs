using RendimentoLiquidos.Test.Dependencias;
using Rendimentos.Api.Calcular;
using Rendimentos.Test.Dependencias;

namespace Rendimentos.Test;

[ClassConstructor<DependencyInjectionClassConstructor>]
internal class CalcularServiceTest(ICalcularService calcularService)
{
    private readonly ICalcularService calcularService = calcularService;

    [Test]
    public async Task Deve_Ter_Taxa_De_Rendimentos_CDI_TB()
    {
        var taxaRendimentos = calcularService.ObterTaxaRendimento();

        await Assert.That(taxaRendimentos).IsEqualTo(0.009m * 1.08m);
    }

    [Test]
    [MethodDataSource(typeof(CalcularImpostoDataSource), nameof(CalcularImpostoDataSource.CalcularImposto))]
    public async Task Deve_Calcular_Imposto(CalcularImpostoData calcularImpostoData)
    {
        var imposto = calcularService.CalcularImposto(calcularImpostoData.Rendimento, calcularImpostoData.Meses);

        await Assert.That(imposto).IsEqualTo(calcularImpostoData.Imposto);
    }

    [Test]
    [MethodDataSource(typeof(CalcularRendimentoDataSource), nameof(CalcularRendimentoDataSource.CalcularRendimento))]
    public async Task Deve_Calcular_Rendimento(CalcularRendimentoData calcularRendimentoData)
    {
        var taxaRendimentos = calcularService.ObterTaxaRendimento();
        var imposto = calcularService.CalcularValorFinal(calcularRendimentoData.ValorInicial, calcularRendimentoData.Meses, taxaRendimentos);

        await Assert.That(imposto).IsEqualTo(calcularRendimentoData.ValorFinal);
    }


    [Test]
    [MethodDataSource(typeof(CalcularRendimentoLiquidoDataSource), nameof(CalcularRendimentoLiquidoDataSource.CalcularRendimentoLiquido))]
    public async Task Deve_Calcular_Rendimento_Liquido(CalcularRendimentoLiquidoData calcularRendimentoData)
    {
        var response = calcularService.CalcularRendimentos(new CalcularRequest { Valor = calcularRendimentoData.ValorInicial, Meses = calcularRendimentoData.Meses });

        await Assert.That(response.HasError).IsFalse();
        await Assert.That(response.HasValue).IsTrue();
        await Assert.That(response.Value).IsNotNull();
        await Assert.That(response.Value!.TotalBruto).IsEqualTo(calcularRendimentoData.TotalBruto);
        await Assert.That(response.Value!.TotalLiquido).IsEqualTo(calcularRendimentoData.TotalLiquido);
        await Assert.That(response.Value!.Deducoes).IsEqualTo(calcularRendimentoData.Deducoes);
        await Assert.That(response.Value!.RendimentoBruto).IsEqualTo(calcularRendimentoData.RendimentoBruto);
        await Assert.That(response.Value!.RendimentoLiquido).IsEqualTo(calcularRendimentoData.RendimentoLiquido);
    }

    [Test]
    public async Task Deve_Impedir_Meses_Menor_Que_Zero()
    {
        var response = calcularService.CalcularRendimentos(new CalcularRequest { Meses = -1, Valor = 10000 });

        await Assert.That(response.HasError).IsTrue();
        await Assert.That(response.HasValue).IsFalse();
        await Assert.That(response.ErrorMessage).IsNotNull().And.IsEqualTo("Meses deve ser positivo");
    }

    [Test]
    public async Task Deve_Impedir_Valor_Menor_Que_Zero()
    {
        var response = calcularService.CalcularRendimentos(new CalcularRequest { Meses = 1, Valor = -10000 });

        await Assert.That(response.HasError).IsTrue();
        await Assert.That(response.HasValue).IsFalse();
        await Assert.That(response.ErrorMessage).IsNotNull().And.IsEqualTo("Valor deve ser positivo");
    }
}
