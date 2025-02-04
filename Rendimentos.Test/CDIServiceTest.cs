using Rendimentos.Api.Calcular;
using Rendimentos.Test.Dependencias;

namespace Rendimentos.Test;

[ClassConstructor<DependencyInjectionClassConstructor>]
internal class CDIServiceTest(ICDIService cdiService)
{
    private readonly ICDIService cdiService = cdiService;

    [Test]
    public async Task Deve_Ser_0_9()
    {
        var tb = cdiService.ObterCDI();

        await Assert.That(tb).IsEqualTo(.009m);
    }
}
