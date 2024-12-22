namespace testes
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Eu gosto de C# e programação.";
            int indice = texto.IndexOf("gosto"); // Retorna 3
            int indic = texto.IndexOf("Java"); // Retorna -1
            int indi = texto.IndexOf("c#", StringComparison.OrdinalIgnoreCase); // Retorna 11

            Console.WriteLine(indice);
            Console.WriteLine(indic);
            Console.WriteLine(indi);
        }
    }
}
