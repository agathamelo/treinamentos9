using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    public static class Listas
    {
        static public void Lista1()
        {
            var lista = new List<int> { 1, 2, 3 };

            //adicionando item na lista
            //lista.Add(4);

            //limpando a lista
            //lista.Clear();

            //removendo item da lista
            //lista.Remove(2);

            //removendo elementos de condições especificas da lista   
            //Predicate<int> predicate = DeixaImpar;
            //lista.RemoveAll(predicate);



            for (var i = 0; i < lista.Count(); i++)
            {
                Console.WriteLine(lista[i]);
            }
        }

        //public static bool DeixaImpar(int numero)
        //{
        //    return numero % 2 == 0 ? true : false; 
        //}
    }
}
