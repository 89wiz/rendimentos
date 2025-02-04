using Rendimentos.Api.Calcular;
using Rendimentos.Test.Dependencias;

namespace Rendimentos.Test;

[ClassConstructor<DependencyInjectionClassConstructor>]
internal class TBServiceTest(ITBService tbService)
{
    private readonly ITBService tbService = tbService;

    [Test]
    public async Task Deve_Ser_108()
    {
        var tb = tbService.ObterTB();

        await Assert.That(tb).IsEqualTo(1.08m);
    }
}
