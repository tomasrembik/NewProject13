namespace NewProject13.tests
{
    public class Tests
    {
       

        [Test]
        public void WhenUserColectTwoPoitShoudesCorectResult()
        {
            var user = new Employee("Tom", "John", 31);

            user.AddScore(4);
            user.AddScore(5);
            user.AddScore(-6);

            var result = user.Result;
            
            Assert.AreEqual(3, result);
        }
    }
}