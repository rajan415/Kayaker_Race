using Kayaker_Race;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestKayaker_Race
{
    [TestClass]
    public class SteveTrue
    {
        [TestMethod]
        public void Steve()
        {
            //tests weather case 0 in the factory class holds PlayerName Steve from Bettors class
            //the test will pass if it is true
            Guy guy = Factory.GetBettorInfo(0);
            Assert.IsTrue(guy.PlayerName.Equals("Steve"));
        }

        [TestMethod]
        public void Dax()

        {
            //tests weather case 1 in the factory clas does NOT hold PlayerName dax from the bettors class
            //the test will pass if it is NOT true
            Guy guy = Factory.GetBettorInfo(1);
            Assert.IsFalse(guy.PlayerName.Equals("Dax"));
        }
    }
}
