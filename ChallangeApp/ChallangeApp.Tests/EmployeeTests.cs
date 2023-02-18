namespace ChallangeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void MaxStats()
        {
            // arrange
            var employee = new Employee("Arkadiusz", "Aleksiejuk");
            //act
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            var statistics = employee.GetStstistics();
            //assert
            Assert.AreEqual(statistics.Max, 6);
        }

        [Test]
        public void MinStats()
        {
            // arrange
            var employee = new Employee("Arkadiusz", "Aleksiejuk");
            //act
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            var statistics = employee.GetStstistics();
            //assert
            Assert.AreEqual(statistics.Min, 2);
        }

        [Test]
        public void AverageStats()
        {
            // arrange
            var employee = new Employee("Arkadiusz", "Aleksiejuk");
            //act
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            var statistics = employee.GetStstistics();
            //assert
            Assert.AreEqual(statistics.Average, 3.33333325f);
        }
    }
}

