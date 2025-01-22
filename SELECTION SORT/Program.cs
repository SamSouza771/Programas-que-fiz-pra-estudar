namespace selectionSort;

class Program
{
    static void Main(string[] args)
    {
        List<int> lista = [92, 11, 56, 7, 34, 64, 89, 29, 1, 54, 47, 63, 82, 21, 38, 15, 77, 9, 63, 50];

        int min_index = 0;

        for (int i = 0; i < lista.Count; i++)
        {
            for (int j = 0; j < lista.Count; j++)
            {
                min_index = i;
                if (lista[j] < lista[min_index])
                {
                    int aux = lista[j];
                    lista[j] = lista[i];
                    lista[i] = aux;
                }
            }
        }

        for (int k = 0; k < lista.Count; k++)
        {
            Console.WriteLine(lista[k]);
        }
    }
}
