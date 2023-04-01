namespace NewProject13.Tests

{
    public class EmployeeTests
    {


        [Test]
        public void WhenUserColectTwoPoitShoudesCorectResult()
        {
            var user = new Employee("Tom", "John");

            user.AddGrade(4);
            user.AddGrade(5);
            user.AddGrade(-6);

            var statistics = user.GetStatistics();

            Assert.AreEqual(5, statistics.Max);
        }

        [Test]
        public void WhenWeAddedGradesLetter_SchouldReturnCorrectStatisticValue()
        {

            // arrange
            Employee user = new Employee("Dawid", "Maj");
            user.AddGrade('A');
            user.AddGrade('B');
            user.AddGrade('C');
            user.AddGrade('D');
            user.AddGrade('E');
            // act
            var statistic = user.GetStatistics();
            // assert
            Assert.That(statistic.Average, Is.EqualTo(60));
        }
        [Test]
        public void WhenWeAddedGrades_SchouldReturnCorrectStatisticValueLetter()
        {
            // arrange
            Employee user = new Employee("Cos");
            user.AddGrade(20);
            user.AddGrade(40);
            user.AddGrade(60);
            user.AddGrade(80);
            user.AddGrade(100);
            // act
            var statistic = user.GetStatistics();
            // assert
            Assert.That('B', Is.EqualTo(statistic.AverageLetter));
        }
    }
}
