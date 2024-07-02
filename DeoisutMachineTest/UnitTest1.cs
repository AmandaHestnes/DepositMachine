using DepositMachine;

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
        public async Task AcceptBottleAsync_ShouldIncreaseTotalAmountAndNumberOfBottles()
        {
            //int totalAmount = _recyclingMachine.Total
            Assert.Pass();
        }
    }
}