using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int []{ 10, 0, 11, -1, 201, 13, 123, 3 };
            Array.Sort(vetor); // ordeno o vetor em ordem crescente


            //Imprimo o Vetor Ordenado
            for (int i = 0; i < vetor.Length; i++)
                Console.Write(vetor[i] + " |");
            Console.WriteLine();

            //testo a busca
            Console.WriteLine("posição do numero 201: " + Find(vetor, 201));
            Console.WriteLine("posição do numero 500: " + Find(vetor, 500));

            Console.ReadLine();
        }

        //retorna indice/posicao onde esta o valor passado
        //como parametro
        static int Find(int[] vet, int valor)
        {
            for(int i=0; i<vet.Length; i++)
            {
                if (vet[i] == valor)
                    return i;
            }
            return -1; //retorna -1 caso o valor não esteja no vetor
        }
    }
}
