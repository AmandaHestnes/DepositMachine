﻿using DepositMachine.Models;

namespace DepositMachine
{
    public class RecyclingMachine
    {
        public int TotalAmount { get; private set; }
        public List<string> Log {  get; private set; }
        public int NrOfCans { get; private set; }
        public int NrOfBottles { get; private set; }    
        public Voucher Voucher { get; private set; }

        public RecyclingMachine()
        {
            TotalAmount = 0;
            Log = new List<string>();
            NrOfBottles = 0;
            NrOfCans = 0;
            Voucher = new Voucher();
        }

        public void AcceptBottle()
        {
            Bottle bottle = new Bottle();
            Thread.Sleep(bottle.ProcessingTime);
            TotalAmount += bottle.Value;
            NrOfBottles++;
            Voucher.Amount += bottle.Value;
            Voucher.NrBottles++;
            Log.Add($"Bottle turned in. Number of bottles {NrOfBottles}");
            Console.WriteLine("Bottle accepted");
            Console.WriteLine($"Bottles:{Voucher.NrBottles} | Cans:{Voucher.NrCans} | Amount:{Voucher.Amount}NOK");
        }

        public void AcceptCan()
        {
            Can can = new Can();
            Thread.Sleep(can.ProcessingTime);
            TotalAmount += can.Value;
            NrOfCans++;
            Voucher.Amount += can.Value;
            Voucher.NrCans++;
            Log.Add($"Can turned in. Number of cans {NrOfCans}");
            Console.WriteLine("Can accepted");
            Console.WriteLine($"Bottles:{Voucher.NrBottles} | Cans:{Voucher.NrCans} | Amount:{Voucher.Amount}NOK");
        }

        public void PrintVoucher()
        {
            Log.Add($"Voucher printed");
            Voucher.PrintVoucher();
            Voucher = new Voucher();
        }

        public void ShowLog()
        {
            Console.WriteLine("Transaction Log:");
            foreach (var entry in Log)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine($"Total amount of cans is {NrOfCans}");
            Console.WriteLine($"Total amount of bottles is {NrOfBottles}");
            Console.WriteLine($"Total amount {TotalAmount}NOK");
        }

    }
}
