namespace DepositMachine
{
    public class Voucher
    {
        public int Amount {  get; set; }
        public int NrBottles { get; set; }
        public int NrCans { get; set; }

        public void PrintVoucher()
        {
            if (Amount > 0)
            {
                Console.WriteLine("\nVOUCHER");
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Voucher Amount: {Amount} NOK");
                Console.WriteLine($"Nr of bottles {NrBottles}");
                Console.WriteLine($"Nr of cans {NrCans} \n");
                Console.WriteLine("Thank you for recycling!!");
                Console.WriteLine("------------------------------");
            }
            else 
            {
                Console.WriteLine("No can or bottle has been added.");
            }

        }
    }
}
