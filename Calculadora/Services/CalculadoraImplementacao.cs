using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImplementacao
    {

        List<int> listaHistorico = new List<int>();
        int tamanhoMaximoListaHistorico = 3;
        public void adicionarResultadoNaLista(int resultado)
        {
            listaHistorico.Add(resultado);
            if (listaHistorico.Count > tamanhoMaximoListaHistorico)
            {
                listaHistorico.RemoveAt(0);
            }

        }        
        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            adicionarResultadoNaLista(resultado);
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            adicionarResultadoNaLista(resultado);
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            adicionarResultadoNaLista(resultado);
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            adicionarResultadoNaLista(resultado);
            return resultado;
        }

        public List<int> Historico()
        {
            return listaHistorico;
        }
    }
}