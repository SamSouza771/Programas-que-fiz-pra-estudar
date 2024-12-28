using System;

namespace bubbleSort;

class Program
{
    static void Main(string[] args)
    {
        int[] lista = [9, 4, 5, 2, 0, 7, 6, 3, 1, 8, 10];

        for (int i = 0; i < lista.Length -1; i++)
        {
            for (int j = 0; j < lista.Length - 1 - i; j++)
            {
                if (lista[j] > lista[j+1])
                {
                    int temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                }
            }
        }

        Console.WriteLine(string.Join(",", lista));

    }
}
