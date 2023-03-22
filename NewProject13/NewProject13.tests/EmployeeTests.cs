namespace NewProject13.tests
{
    public class Tests
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
    }
}