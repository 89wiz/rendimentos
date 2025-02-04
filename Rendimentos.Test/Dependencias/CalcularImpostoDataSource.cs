namespace Rendimentos.Test.Dependencias;

public record CalcularImpostoData(decimal Rendimento, int Meses, decimal Imposto);

internal class CalcularImpostoDataSource
{
    public static IEnumerable<Func<CalcularImpostoData>> CalcularImposto()
    {
        yield return () => new CalcularImpostoData(10000, 1, 2250);
        yield return () => new CalcularImpostoData(10000, 2, 2250);
        yield return () => new CalcularImpostoData(10000, 3, 2250);
        yield return () => new CalcularImpostoData(10000, 4, 2250);
        yield return () => new CalcularImpostoData(10000, 5, 2250);
        yield return () => new CalcularImpostoData(10000, 6, 2250);

        yield return () => new CalcularImpostoData(10000, 7, 2000);
        yield return () => new CalcularImpostoData(10000, 8, 2000);
        yield return () => new CalcularImpostoData(10000, 9, 2000);
        yield return () => new CalcularImpostoData(10000, 10, 2000);
        yield return () => new CalcularImpostoData(10000, 11, 2000);
        yield return () => new CalcularImpostoData(10000, 12, 2000);

        yield return () => new CalcularImpostoData(10000, 13, 1750);
        yield return () => new CalcularImpostoData(10000, 14, 1750);
        yield return () => new CalcularImpostoData(10000, 15, 1750);
        yield return () => new CalcularImpostoData(10000, 16, 1750);
        yield return () => new CalcularImpostoData(10000, 17, 1750);
        yield return () => new CalcularImpostoData(10000, 18, 1750);
        yield return () => new CalcularImpostoData(10000, 19, 1750);
        yield return () => new CalcularImpostoData(10000, 20, 1750);
        yield return () => new CalcularImpostoData(10000, 21, 1750);
        yield return () => new CalcularImpostoData(10000, 22, 1750);
        yield return () => new CalcularImpostoData(10000, 23, 1750);
        yield return () => new CalcularImpostoData(10000, 24, 1750);

        yield return () => new CalcularImpostoData(10000, 25, 1500);
        yield return () => new CalcularImpostoData(10000, 26, 1500);
        yield return () => new CalcularImpostoData(10000, 27, 1500);
        yield return () => new CalcularImpostoData(10000, 28, 1500);
        yield return () => new CalcularImpostoData(10000, 29, 1500);
        yield return () => new CalcularImpostoData(10000, 30, 1500);
        yield return () => new CalcularImpostoData(10000, 31, 1500);
        yield return () => new CalcularImpostoData(10000, 32, 1500);
        yield return () => new CalcularImpostoData(10000, 33, 1500);
        yield return () => new CalcularImpostoData(10000, 34, 1500);
        yield return () => new CalcularImpostoData(10000, 35, 1500);
        yield return () => new CalcularImpostoData(10000, 36, 1500);
    }
}
