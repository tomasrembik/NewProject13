
using System.Runtime.CompilerServices;

namespace NewProject13.tests
{
    public class TypeTests // Dodanie testrow dzien 8
    {

        [Test]
        public void TestEmployeeTwo()
        {
            var user1 = GetEmployee("Tomek");
            var user2 = GetEmployee("Marek");

            Assert.AreNotEqual(user1, user2);  

        }
        [Test]
        public void TestStringEmployee()
        {
            string number1 = "Tomek";
            string number2 = "Tomek";

            Assert.AreEqual(number1, number2 );

        }


        private Employee GetEmployee(string name) 
        {
           return new Employee(name);
        }
        
    }

}
