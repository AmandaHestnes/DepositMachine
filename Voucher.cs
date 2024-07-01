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
            Console.WriteLine("Voucher Amount: {Amount} NOK");
        }
    }
}
