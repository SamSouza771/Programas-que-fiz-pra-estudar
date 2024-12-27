namespace binarysearch
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] lista = new int[] { 4, 7, 14, 25, 33, 41, 48, 51, 67, 70, 72, 75, 77, 79, 80, 81, 91, 94, 95, 98 };

            Console.WriteLine(Busca(48, lista));
            Console.WriteLine(Busca(98, lista));
            Console.WriteLine(Busca(79, lista));
            Console.WriteLine(Busca(215, lista));
            Console.WriteLine(Busca(51, lista));
            Console.WriteLine(Busca(25, lista));
        }

        public static int Busca(int target, int[] lista)
        {
            int head = 0;
            int tail = lista.Length - 1;
            int pivot;

            while (head <= tail)
            {
                pivot = head + tail / 2;

                Console.WriteLine("pivot: " + pivot);
                Console.WriteLine("head: " + head);
                Console.WriteLine("tail: " + tail);
                Console.WriteLine("--------------------");

                if (lista[pivot] > target)
                {
                    tail = pivot - 1;
                }
                else if (lista[pivot] < target)
                {
                    head = pivot + 1;
                }
                else
                {
                    return lista[pivot];
                }
            }

            return -1;
        }
    }
}
