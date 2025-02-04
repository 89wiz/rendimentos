using Rendimentos.Api.Calcular;
using Rendimentos.Test.Dependencias;

namespace Rendimentos.Test;

[ClassConstructor<DependencyInjectionClassConstructor>]
internal class ImpostoServiceTest(IImpostoService impostoService)
{
    private readonly IImpostoService impostoService = impostoService;

    [Test]
    [MethodDataSource(typeof(ImpostoDataSource), nameof(ImpostoDataSource.Imposto6Meses))]
    public async Task Deve_Ter_Imposto_De_22_5_Ate_6_Meses(ImpostoData impostoData)
    {
        var imposto = impostoService.ObterImposto(impostoData.Meses);

        await Assert.That(imposto).IsEqualTo(impostoData.Imposto);
    }

    [Test]
    [MethodDataSource(typeof(ImpostoDataSource), nameof(ImpostoDataSource.Imposto12Meses))]
    public async Task Deve_Ter_Imposto_De_20_Ate_12_Meses(ImpostoData impostoData)
    {
        var imposto = impostoService.ObterImposto(impostoData.Meses);

        await Assert.That(imposto).IsEqualTo(impostoData.Imposto);
    }

    [Test]
    [MethodDataSource(typeof(ImpostoDataSource), nameof(ImpostoDataSource.Imposto24Meses))]
    public async Task Deve_Ter_Imposto_De_17_5_Ate_24_Meses(ImpostoData impostoData)
    {
        var imposto = impostoService.ObterImposto(impostoData.Meses);

        await Assert.That(imposto).IsEqualTo(impostoData.Imposto);
    }

    [Test]
    [MethodDataSource(typeof(ImpostoDataSource), nameof(ImpostoDataSource.ImpostoMaximo))]
    public async Task Deve_Ter_Imposto_De_15_Acima_De_24_Meses(ImpostoData impostoData)
    {
        var imposto = impostoService.ObterImposto(impostoData.Meses);

        await Assert.That(imposto).IsEqualTo(impostoData.Imposto);
    }
}
