namespace ChallangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void IntegerNumberCheck()
        {
            // arrange
            var intNumber = 1;
            var intNumber2 = 2;
            // act   

            //assert
            Assert.AreNotEqual(intNumber, intNumber2);
        }

        [Test]
        public void StringValueCheck()
        {
            // arrange
            var stringName = "Arek";
            var stringName2 = "Arek";
            // act   

            //assert
            Assert.AreEqual(stringName, stringName2);
        }

        [Test]
        public void FloatNumberCheck()
        {
            // arrange
            var floatNumber = 5.0F;
            var floatNumber2 = 5.0F;
            // act   

            //assert
            Assert.AreEqual(floatNumber, floatNumber2);
        }

        [Test]
        public void ReferenceTypeCheckTest()
        {
            // arrange
            var user1 = GetUser("Arek");
            var user2 = GetUser("Adam");
            // act   

            //assert
            Assert.AreNotEqual(user1, user2);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}


