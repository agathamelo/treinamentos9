using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    static public class Funcao
    {
        
        //criar função que converta uma string em um int
        static public int Converte(string recebe) 
        {
            return (Convert.ToInt32(recebe));
        }

        //recebe um float e devolve um int
        static public int Converte (float recebe)
        {
            return (Convert.ToInt32(recebe));
        }

        //recebe uma string e devolve a quantidade de caracter que a string contem 
        static public int QuantidadeCaracter (string recebe)
        {
            return Convert.ToInt32(recebe.Length);
        }

        //recebe uma frase e devolve a quantidade de caracteres da string sem os espaços
        static public int QuantidadeCaracter1 (string recebe)
        {
            var semespaco = recebe.Trim();
            return Convert.ToInt32(semespaco.Length);
        }
        //receber tres variaveis e devolver a formula de bhaskara
        static public Tuple<double, double> Bhaskara (int a, int b, int c)
        {
            var delta = (b * b) - 4 * a * c;

            if (delta < 0)
            {
                throw new Exception("Não é possivel calcular bhaskara.");
            }

            var raiz = Math.Sqrt(delta);
            var x1 = (-b + raiz) / 2 * a;
            var x2 = (-b - raiz) / 2 * a;

            return new Tuple<double, double>(x1, x2);        
        }
       
    }
}
