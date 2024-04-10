namespace ProjetoTest;
using Calculadora.Services;

public class CalculadoraTest
{

    public Calculadora ConstruirClasse()
    {
        string data = "09/04/2024";
        Calculadora calc = new Calculadora(data);
        return calc;
    }

    [Theory]
    [InlineDataAttribute(1, 2, 3)]
    [InlineDataAttribute(4, 5, 9)]
    public void TesteSomar(int x, int y, int res)
    {
        Calculadora calc = ConstruirClasse();

        int resultado = calc.Somar(x, y);

        Assert.Equal(res, resultado);
    }
    [Theory]
    [InlineDataAttribute(5, 2, 3)]
    [InlineDataAttribute(12, 3, 9)]
    public void TesteSub(int x, int y, int res)
    {
        Calculadora calc = ConstruirClasse();

        int resultado = calc.Subtrair(x, y);

        Assert.Equal(res, resultado);
    }
    [Theory]
    [InlineDataAttribute(2, 2, 4)]
    [InlineDataAttribute(11, 11, 121)]
    public void TesteMult(int x, int y, int res)
    {
        Calculadora calc = ConstruirClasse();

        int resultado = calc.Multiplicar(x, y);

        Assert.Equal(res, resultado);
    }
    [Theory]
    [InlineDataAttribute(4, 2, 2)]
    [InlineDataAttribute(6, 2, 3)]
    public void TesteDiv(int x, int y, int res)
    {
        Calculadora calc = ConstruirClasse();

        int resultado = calc.Dividir(x, y);

        Assert.Equal(res, resultado);
    }
    [Fact]
    public void TesteDivPorZero()
    {
        Calculadora calc = ConstruirClasse();
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }
    [Fact]
    public void TesteHistorico()
    {
        Calculadora calc = ConstruirClasse();
        calc.Somar(1, 2);
        calc.Somar(3, 4);
        calc.Somar(6, 2);
        calc.Somar(12, 3);
        calc.Somar(1, 4);

        var lista = calc.Historico();

        Assert.NotEmpty(calc.Historico());
        Assert.Equal(3, lista.Count);
    }
}