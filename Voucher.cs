namespace DepositMachine
{
    public class Voucher
    {
        public int Amount {  get; private set; }
        public int NrBottles { get; private set; }
        public int NrCans { get; private set; }

        public Voucher(int amount, int nrBottles, int nrCans)
        {
            this.Amount = amount;
            this.NrBottles = nrBottles;
            this.NrCans = nrCans;
        }

        public void PrintVoucher()
        {
            Console.WriteLine("\nVOUCHER");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Voucher Amount: {Amount} NOK");
            Console.WriteLine($"Nr of bottles {NrBottles}");
            Console.WriteLine($"Nr of cans {NrCans} \n");
            Console.WriteLine("Thank you for recycling!!");
            Console.WriteLine("------------------------------");
        }
    }
}
