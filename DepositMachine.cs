using DepositMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositMachine
{
    public class DepositMachine
    {
        private int totalAmount;
        private List<string> log;
        private int nrOfCans;
        private int nrOfBottles;
        private int voucherNrCans;
        private int voucherNrBottles;
        private int voutcherAmount;

        public DepositMachine()
        {
            totalAmount = 0;
            log = new List<string>();
            nrOfBottles = 0;
            nrOfCans = 0;
            voucherNrCans = 0;
            voucherNrBottles = 0;
            voutcherAmount = 0;
        }

        public async Task AcceptBottleAsync()
        {
            Bottle bottle = new Bottle();
            await Task.Delay(bottle.ProcessingTime);
            totalAmount += bottle.Value;
            voutcherAmount += bottle.Value;
            nrOfBottles++;
            voucherNrBottles++;
            log.Add($"Bottle turned in. Nr of bottles turned in is {nrOfBottles}");
            Console.WriteLine("Bottle accepted");
        }

        public async Task AcceptCanAsync()
        {
            Can can = new Can();
            await Task.Delay(can.ProcessingTime);
            totalAmount += can.Value;
            voutcherAmount += can.Value;
            nrOfCans++;
            voucherNrCans++;
            log.Add($"Can turned in. Nr of cans turned in is {nrOfCans}");
            Console.WriteLine("Can accepted");
        }

        public void PrintVoucher()
        {
            Voucher voucher = new Voucher(totalAmount, voucherNrBottles, voucherNrCans);
            log.Add($"Voucher: {voucher}");
            ResetVoucherCountAndAmount();
            voucher.PrintVoucher();
        }
        internal void ResetVoucherCountAndAmount()
        {
            voutcherAmount = 0;
            voucherNrBottles = 0 ;
            voucherNrCans = 0 ;
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
