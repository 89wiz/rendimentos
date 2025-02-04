using Microsoft.Extensions.DependencyInjection;
using Rendimentos.Api.Calcular;
using System.Diagnostics.CodeAnalysis;
using TUnit.Core.Interfaces;

namespace Rendimentos.Test.Dependencias;

public class DependencyInjectionClassConstructor : IClassConstructor, ITestEndEventReceiver
{
    private static readonly IServiceProvider _serviceProvider = CreateServiceProvider();

    private AsyncServiceScope _scope;

    public T Create<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T>(ClassConstructorMetadata classConstructorMetadata)
        where T : class
    {
        _scope = _serviceProvider.CreateAsyncScope();

        return ActivatorUtilities.GetServiceOrCreateInstance<T>(_scope.ServiceProvider);
    }

    public ValueTask OnTestEnd(TestContext testContext)
    {
        return _scope.DisposeAsync();
    }

    private static IServiceProvider CreateServiceProvider()
    {
        return new ServiceCollection()
            .AddSingleton<ICalcularService, CalcularService>()
            .AddSingleton<IImpostoService, ImpostoService>()
            .AddSingleton<ICDIService, CDIService>()
            .AddSingleton<ITBService, TBService>()
            .BuildServiceProvider();
    }
}