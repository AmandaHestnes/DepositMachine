namespace DepositMachine
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            DepositMachine machine = new DepositMachine();

            Console.WriteLine("Can/Bottle Deposit Machine");
            Console.WriteLine("1. Turn in a bottle");
            Console.WriteLine("2. Turn in a can");
            Console.WriteLine("3. Print voucher");
            Console.WriteLine("4. Show log");
            Console.WriteLine("5. Exit");

            while (true) 
            {
                Console.WriteLine("Choose an option");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await machine.AcceptBottleAsync();
                        break;
                    case "2":
                        await machine.AcceptCanAsync();
                        break;
                    case "3":
                        machine.PrintVoucher();
                        break;
                    case "4":
                        machine.ShowLog();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }

            
        }
    }
}
