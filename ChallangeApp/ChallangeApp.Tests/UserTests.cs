namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
      public void CheckingMinusScorePointsEmployee ()
        {
            // arrange
            var user = new User("Kazik", "Kowalski");
            user.AddScore(8);
            user.AddScore(6);
            user.AddScore(1);
            user.AddMinusScore(15);
            // act   
            var result = user.Result;

            //assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CheckingScorePointsEmployee()
        {
            // arrange
            var user = new User("Kazik", "Kowalski");
            user.AddScore(8);
            user.AddScore(6);
            user.AddScore(1);
            user.AddScore(15);
            // act   
            var result = user.Result;

            //assert
            Assert.AreEqual(30, result);
        }
    }
}