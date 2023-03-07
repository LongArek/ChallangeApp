namespace ChallangeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void LetterAverageCheck()
        {
            // arrange
            var employee = new Employee("Arkadiusz", "Aleksiejuk");
            //act
            employee.AddGrade('e');
            employee.AddGrade('a');
            employee.AddGrade('D');
            employee.AddGrade(80);
            employee.AddGrade(80);
            var statistics = employee.GetStstistics();
            //assert
            Assert.AreEqual('b', statistics.AverageLetter);
            Assert.AreEqual(64.0f, statistics.Average);
            Assert.AreEqual(20, statistics.Min);
            Assert.AreEqual(100.0f, statistics.Max);
        }
    }
}



