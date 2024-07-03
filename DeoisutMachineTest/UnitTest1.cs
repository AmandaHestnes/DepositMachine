using DepositMachine;
using NUnit.Framework.Legacy;

namespace DeoisutMachineTest
{
    public class DepositMachineTests {

        private RecyclingMachine _recyclingMachine;

        [SetUp]
        public void Setup()
        {
            _recyclingMachine = new RecyclingMachine();
        }

        [Test]
        public void AcceptBottle_ShouldIncreaseTotalAmountAndNumberOfBottles()
        {
            int totalAmount = _recyclingMachine.TotalAmount;
            int nrOfBottles = _recyclingMachine.NrOfBottles;

            _recyclingMachine.AcceptBottle();

            Assert.That(totalAmount + 3, Is.EqualTo(_recyclingMachine.TotalAmount));
            Assert.That(nrOfBottles + 1, Is.EqualTo(_recyclingMachine.NrOfBottles));
        }

        [Test]
        public void AcceptCan_ShouldIncreaseTotalAmountAndNumberOfCans()
        {
            int totalAmount = _recyclingMachine.TotalAmount;
            int nrOfCans = _recyclingMachine.NrOfCans;

            _recyclingMachine.AcceptCan();

            Assert.That(totalAmount + 2, Is.EqualTo(_recyclingMachine.TotalAmount));
            Assert.That(nrOfCans + 1, Is.EqualTo(_recyclingMachine.NrOfCans));
        }

        [Test]
        public void PrintVoucher_ShouldResetVoucherAmountAndCount()
        {
            _recyclingMachine.AcceptBottle();
            _recyclingMachine.AcceptCan();
            _recyclingMachine.AcceptCan();
            int voucherAmountBeforePrint = _recyclingMachine.Voucher.Amount;

            _recyclingMachine.PrintVoucher();

            Assert.That(_recyclingMachine.Voucher.Amount, Is.EqualTo(0));
            Assert.That(_recyclingMachine.Voucher.Amount, Is.Not.EqualTo(voucherAmountBeforePrint));
            Assert.That(_recyclingMachine.Voucher.NrBottles, Is.EqualTo(0));
            Assert.That(_recyclingMachine.Voucher.NrCans, Is.EqualTo(0));
        }
        [Test]

        public void PrintVoucher_ShouldNotResetCountAndTotalAmount()
        {
            _recyclingMachine.AcceptBottle();
            _recyclingMachine.AcceptCan();
            _recyclingMachine.AcceptCan();
            int totalAmoundBeforePrint = _recyclingMachine.TotalAmount;
            int nrOfBottles = _recyclingMachine.NrOfBottles;
            int nrOfCans = _recyclingMachine.NrOfCans;

            _recyclingMachine.PrintVoucher();

            Assert.That(_recyclingMachine.TotalAmount, Is.Not.EqualTo(0));
            Assert.That(_recyclingMachine.TotalAmount, Is.EqualTo(totalAmoundBeforePrint));
            Assert.That(_recyclingMachine.NrOfBottles, Is.EqualTo(nrOfBottles));
            Assert.That(_recyclingMachine.NrOfCans, Is.EqualTo(nrOfCans));
        }

        [Test]
        public void Log_ShouldHaveTheRightNumberOfLogs()
        {
            _recyclingMachine.AcceptBottle();
            _recyclingMachine.AcceptCan();
            _recyclingMachine.PrintVoucher();
            _recyclingMachine.AcceptBottle();

            int nrOfEntry = 4;

            Assert.That(_recyclingMachine.Log.Count, Is.EqualTo(nrOfEntry));
        }

        [Test]
        public void ShowLog_ShuldNotResetCountAndTotalAmount()
        {
            _recyclingMachine.AcceptBottle();
            _recyclingMachine.AcceptCan();
            _recyclingMachine.AcceptCan();
            int totalAmoundBeforeShowLog = _recyclingMachine.TotalAmount;
            int nrOfBottles = _recyclingMachine.NrOfBottles;
            int nrOfCans = _recyclingMachine.NrOfCans;

            _recyclingMachine.ShowLog();

            Assert.That(_recyclingMachine.TotalAmount, Is.Not.EqualTo(0));
            Assert.That(_recyclingMachine.TotalAmount, Is.EqualTo(totalAmoundBeforeShowLog));
            Assert.That(_recyclingMachine.NrOfBottles, Is.EqualTo(nrOfBottles));
            Assert.That(_recyclingMachine.NrOfCans, Is.EqualTo(nrOfCans));
        }

        [Test]
        public void ShowLog_ShuldNotResetVoucherCountAndAmount()
        {
            _recyclingMachine.AcceptBottle();
            _recyclingMachine.AcceptCan();
            _recyclingMachine.AcceptCan();
            int totalAmoundBeforeShowLog= _recyclingMachine.Voucher.Amount;
            int nrOfBottles = _recyclingMachine.Voucher.NrBottles;
            int nrOfCans = _recyclingMachine.Voucher.NrCans;

            _recyclingMachine.ShowLog();

            Assert.That(_recyclingMachine.Voucher.Amount, Is.Not.EqualTo(0));
            Assert.That(_recyclingMachine.Voucher.Amount, Is.EqualTo(totalAmoundBeforeShowLog));
            Assert.That(_recyclingMachine.Voucher.NrBottles, Is.EqualTo(nrOfBottles));
            Assert.That(_recyclingMachine.Voucher.NrCans, Is.EqualTo(nrOfCans));
        }
    }
}