using DepositMachine.Models;

namespace DepositMachine
{
    public class DepositMachine
    {
        private int totalAmount;
        private List<string> log;
        private int nrOfCans;
        private int nrOfBottles;
        private Voucher voucher;

        public DepositMachine()
        {
            totalAmount = 0;
            log = new List<string>();
            nrOfBottles = 0;
            nrOfCans = 0;
            voucher = new Voucher();
        }

        public async Task AcceptBottleAsync()
        {
            Bottle bottle = new Bottle();
            await Task.Delay(bottle.ProcessingTime);
            totalAmount += bottle.Value;
            nrOfBottles++;
            voucher.Amount += bottle.Value;
            voucher.NrBottles++;
            log.Add($"Bottle turned in. Number of bottles {nrOfBottles}");
            Console.WriteLine("Bottle accepted");
        }

        public async Task AcceptCanAsync()
        {
            Can can = new Can();
            await Task.Delay(can.ProcessingTime);
            totalAmount += can.Value;
            nrOfCans++;
            voucher.Amount += can.Value;
            voucher.NrCans++;
            log.Add($"Can turned in. Number of cans {nrOfCans}");
            Console.WriteLine("Can accepted");
        }

        public void PrintVoucher()
        {
            log.Add($"Voucher printed");
            voucher.PrintVoucher();
            voucher = new Voucher();
        }

        public void ShowLog()
        {
            Console.WriteLine("Transaction Log:");
            foreach (var entry in log)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine($"Total amount of cans is {nrOfCans}");
            Console.WriteLine($"Total amount of bottles is {nrOfBottles}");
            Console.WriteLine($"Total amount {totalAmount}NOK");
        }

    }
}
