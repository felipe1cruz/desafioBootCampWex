using Calculadora.Services;

namespace CalculadoraTeste;

public class CalculadoraTestes
{

    CalculadoraImplementacao calc = new CalculadoraImplementacao(); 

    [Fact]
    public void FuncaoSomar8mais8deveretornar16()
    {
        //Arrange
        int num1 = 8;
        int num2 = 8;

        //Act
        int resultadoFuncao = calc.Somar(num1, num2);
        int resultadoEsperado = 16;
        //Assert
        Assert.Equal(resultadoEsperado, resultadoFuncao);
    }

    [Fact]
    public void FuncaoSubtrair8menos8deveretornar0()
    {
        //Arrange
        int num1 = 8;
        int num2 = 8;

        //Act
        int resultadoFuncao = calc.Subtrair(num1, num2);
        int resultadoEsperado = 0;
        //Assert
        Assert.Equal(resultadoEsperado, resultadoFuncao);
    }

    [Fact]
    public void FuncaoMultiplicar8vezes8deveretornar64()
    {
        //Arrange
        int num1 = 8;
        int num2 = 8;

        //Act
        int resultadoFuncao = calc.Multiplicar(num1, num2);
        int resultadoEsperado = 64;
        //Assert
        Assert.Equal(resultadoEsperado, resultadoFuncao);
    }

    [Fact]
    public void FuncaoDividir8por8deveretornar1()
    {
        //Arrange
        int num1 = 8;
        int num2 = 8;

        //Act
        int resultadoFuncao = calc.Dividir(num1, num2);
        int resultadoEsperado = 1;
        //Assert
        Assert.Equal(resultadoEsperado, resultadoFuncao);
    }

    [Theory]
    [InlineData(2, 2, new[] {4, 0, 4})]
    public void FuncaoHistoricoDeveRetornarUmaListaCom(int num1, int num2, int[] valoresEsperados)
    {
        //Arrange
        calc.Somar(num1, num2);
        calc.Subtrair(num1, num2);
        calc.Multiplicar(num1, num2);
        //Act
        List<int> resultadoHistorico = calc.Historico();
        int tamanhoLengthEsperada = 3;
        List<int> listaEsperada = new List<int>();
        //Assert
        Assert.NotEmpty(resultadoHistorico);
        Assert.Equal(tamanhoLengthEsperada, resultadoHistorico.Count());
        Assert.Equal(valoresEsperados, resultadoHistorico);
    }

    
}