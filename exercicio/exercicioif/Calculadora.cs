using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    /*Cria uma classe que se chama Calculadora e que contenha as funções Somar, Subtrair, Dividir e Multiplicar 
      e utiliza em uma calculadora funcional feita com WHILE, dada nos exercícios anteriores.*/
    public class Calculadora
    {
       // //propriedades
       // public int num1;
       // public int num2;

       ////funcionalidades
       //public int soma()
       // {
       //     int resultado = num1 + num2;
       //     return resultado;
       // }

        //soma
        public int Soma(int num1, int num2)
        {
            return num1 + num2;
        }
        //subtração
        public int Subtracao(int num1, int num2)
        {
            return num1 - num2;
        }
        //multiplicação
        public int Multiplicacao(int num1, int num2)
        {
            return num1 * num2;
        }
        //divisão
        public int Divisao(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
