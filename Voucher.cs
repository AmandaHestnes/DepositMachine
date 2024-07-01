namespace DepositMachine
{
    internal class Voucher
    {
        public int Amount {  get; private set; }

        public Voucher(int amount)
        {
            this.Amount = amount;
        }

        public void PrintVoucher()
        {
            Console.WriteLine("Voucher Amount: {Amount} NOK");
        }
    }
}
