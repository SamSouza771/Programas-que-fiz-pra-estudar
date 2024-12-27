namespace Dev
{
    class Program
    {
        static void Main(string[] args)
        {
            var ContaBanco = new ContaBanco(1, "", 0);

            Console.WriteLine("CRIANDO CONTA BANCÁRIA");
            Console.WriteLine("Qual seu Nome: ");
            ContaBanco.Name = Console.ReadLine();
            CheckContaBanco(ContaBanco);
        }

        static void CheckContaBanco(ContaBanco conta)
        {
            Console.WriteLine($"Olá {conta.Name} seu saldo bancário contém R$ {conta.Money}");

            Console.WriteLine("Quer depositar algum valor? ");
            string depost = Console.ReadLine().ToUpper();

            if (!depost.Contains("N"))
            {
                DepositContaBanco(conta);
            }
            else
            {
                Console.WriteLine("adeus");
            }
        }

        static void DepositContaBanco(ContaBanco conta)
        {
            Console.WriteLine("quanto você quer depositar na sua conta: R$ ");
            int deposit = Convert.ToInt32(Console.ReadLine());

            conta.Money = (int)deposit;

            Console.WriteLine("Quer sacar algum valor? ");
            string saque = Console.ReadLine().ToUpper();

            if (!saque.Contains("N"))
            {
                WithdrawContaBanco(conta);
            }
            else
            {
                Console.WriteLine("adeus");
            }
        }

        static void WithdrawContaBanco(ContaBanco conta)
        {
            Console.WriteLine("quanto você quer sacar?");
            int withdraw = Convert.ToInt32(Console.ReadLine());

            if ((int)withdraw > conta.Money)
            {
                Console.WriteLine("valor não permitido");
                WithdrawContaBanco(conta);
            }
            else
            {
                conta.Money = (int)withdraw;
                CheckContaBanco(conta);
            }
        }
    }

    struct ContaBanco
    {
        public ContaBanco(int id, string name, int money)
        {
            Id = id;
            Name = name;
            Money = money;
        }

        public int Id;
        public string Name;
        public int Money;
    }
}
