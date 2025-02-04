namespace Rendimentos.Test.Dependencias;

public record ImpostoData(int Meses, decimal Imposto);

internal class ImpostoDataSource
{
    public static IEnumerable<Func<ImpostoData>> Imposto6Meses()
    {
        yield return () => new ImpostoData(1, .225m);
        yield return () => new ImpostoData(2, .225m);
        yield return () => new ImpostoData(3, .225m);
        yield return () => new ImpostoData(4, .225m);
        yield return () => new ImpostoData(5, .225m);
        yield return () => new ImpostoData(6, .225m);
    }

    public static IEnumerable<Func<ImpostoData>> Imposto12Meses()
    {
        yield return () => new ImpostoData(7, .2m);
        yield return () => new ImpostoData(8, .2m);
        yield return () => new ImpostoData(9, .2m);
        yield return () => new ImpostoData(10, .2m);
        yield return () => new ImpostoData(11, .2m);
        yield return () => new ImpostoData(12, .2m);
    }

    public static IEnumerable<Func<ImpostoData>> Imposto24Meses()
    {
        yield return () => new ImpostoData(13, .175m);
        yield return () => new ImpostoData(14, .175m);
        yield return () => new ImpostoData(15, .175m);
        yield return () => new ImpostoData(16, .175m);
        yield return () => new ImpostoData(17, .175m);
        yield return () => new ImpostoData(18, .175m);
        yield return () => new ImpostoData(19, .175m);
        yield return () => new ImpostoData(20, .175m);
        yield return () => new ImpostoData(21, .175m);
        yield return () => new ImpostoData(22, .175m);
        yield return () => new ImpostoData(23, .175m);
        yield return () => new ImpostoData(24, .175m);
    }

    public static IEnumerable<Func<ImpostoData>> ImpostoMaximo()
    {
        yield return () => new ImpostoData(25, .15m);
        yield return () => new ImpostoData(26, .15m);
        yield return () => new ImpostoData(27, .15m);
        yield return () => new ImpostoData(28, .15m);
        yield return () => new ImpostoData(29, .15m);
        yield return () => new ImpostoData(30, .15m);
        yield return () => new ImpostoData(31, .15m);
        yield return () => new ImpostoData(32, .15m);
        yield return () => new ImpostoData(33, .15m);
        yield return () => new ImpostoData(34, .15m);
        yield return () => new ImpostoData(35, .15m);
        yield return () => new ImpostoData(36, .15m);
    }
}
