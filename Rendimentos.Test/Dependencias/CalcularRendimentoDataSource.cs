namespace Rendimentos.Test.Dependencias;

public record CalcularRendimentoData(decimal ValorInicial, int Meses, decimal ValorFinal);

internal class CalcularRendimentoDataSource
{
    public static IEnumerable<Func<CalcularRendimentoData>> CalcularRendimento()
    {
        yield return () => new CalcularRendimentoData(10000, 1, 10097.2m);
        yield return () => new CalcularRendimentoData(10000, 2, 10195.3447840000m);
        yield return () => new CalcularRendimentoData(10000, 3, 10294.443535300480000m);
        yield return () => new CalcularRendimentoData(10000, 4, 10394.50552646360066560000m);
        yield return () => new CalcularRendimentoData(10000, 5, 10495.540120180826864069632000m);
        yield return () => new CalcularRendimentoData(10000, 6, 10597.556770148984501188388823m);
        yield return () => new CalcularRendimentoData(10000, 7, 10700.565021954832630539939962m);
        yield return () => new CalcularRendimentoData(10000, 8, 10804.574513968233603708788178m);
        yield return () => new CalcularRendimentoData(10000, 9, 10909.594978244004834336837599m);
        yield return () => new CalcularRendimentoData(10000, 10, 11015.636241432536561326591660m);
        yield return () => new CalcularRendimentoData(10000, 11, 11122.708225699260816702686131m);
        yield return () => new CalcularRendimentoData(10000, 12, 11230.820949653057631841036240m);
        yield return () => new CalcularRendimentoData(10000, 13, 11339.984529283685352022531112m);
        yield return () => new CalcularRendimentoData(10000, 14, 11450.209178908322773644190114m);
        yield return () => new CalcularRendimentoData(10000, 15, 11561.505212127311671004011642m);
        yield return () => new CalcularRendimentoData(10000, 16, 11673.883042789189140446170635m);
        yield return () => new CalcularRendimentoData(10000, 17, 11787.353185965100058891307414m);
        yield return () => new CalcularRendimentoData(10000, 18, 11901.926258932680831463730922m);
        yield return () => new CalcularRendimentoData(10000, 19, 12017.612982169506489145558387m);
        yield return () => new CalcularRendimentoData(10000, 20, 12134.424180356194092220053215m);
        yield return () => new CalcularRendimentoData(10000, 21, 12252.370783389256298796432132m);
        yield return () => new CalcularRendimentoData(10000, 22, 12371.463827403799870020733452m);
        yield return () => new CalcularRendimentoData(10000, 23, 12491.714455806164804757334981m);
        yield return () => new CalcularRendimentoData(10000, 24, 12613.133920316600726659576277m);
        yield return () => new CalcularRendimentoData(10000, 25, 12735.733582022078085722707358m);
        yield return () => new CalcularRendimentoData(10000, 26, 12859.524912439332684715932074m);
        yield return () => new CalcularRendimentoData(10000, 27, 12984.519494588242998411370934m);
        yield return () => new CalcularRendimentoData(10000, 28, 13110.729024075640720355929459m);
        yield return () => new CalcularRendimentoData(10000, 29, 13238.165310189655948157789093m);
        yield return () => new CalcularRendimentoData(10000, 30, 13366.840277004699403973882803m);
        yield return () => new CalcularRendimentoData(10000, 31, 13496.765964497185082180508944m);
        yield return () => new CalcularRendimentoData(10000, 32, 13627.954529672097721179303491m);
        yield return () => new CalcularRendimentoData(10000, 33, 13760.418247700510511029166321m);
        yield return () => new CalcularRendimentoData(10000, 34, 13894.169513068159473196369818m);
        yield return () => new CalcularRendimentoData(10000, 35, 14029.220840735181983275838533m);
        yield return () => new CalcularRendimentoData(10000, 36, 14165.584867307127952153279684m);
    }
}
