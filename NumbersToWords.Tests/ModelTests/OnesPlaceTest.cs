using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
    [TestClass]
    public class OnesTests
    {
        [TestMethod]
        public void OnesConstructor_CreateInstanceOfOnesPlace_OnesPlace()
        {
            OnesPlace newOnesPlace = new OnesPlace(1);
            Assert.AreEqual(typeof(OnesPlace), newOnesPlace.GetType());
        }

        [TestMethod]
        public void OnesContructor_GetOnesPlace_Int()
        {
            OnesPlace newOne = new OnesPlace(2);
            int expected = 2;
            Assert.AreEqual(newOne.Num, expected);
        }

        [TestMethod]
        public void OnesConstructor_SetOnesPlace_Void()
        {
            OnesPlace three = new OnesPlace(3);
            int four = 4;
            three.Num = 4;
            Assert.AreEqual(three.Num, four);
        }
    }
}
