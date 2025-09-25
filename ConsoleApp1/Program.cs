
using System.Security.Cryptography.X509Certificates;

using System.Text;


namespace Laboratorna1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, world!");
        }
    }

    public class Employee
    {
        public string Name;
        public string lastName;
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18 && value > 50)
                {
                    age = value;
                }    
                  else
                    throw new ArgumentException("Вік має бути в межах 18–50");
            }
        }



    }

    public class Meneger : Employee
    {
        protected int Subordinates;
    }

    public class Developer : Employee
    {
        protected string ProgrammingLanguage;
    }
    public class Tester : Employee
    {
        protected string method1 = "Функціональне тестування";
        protected string method2 = "Тестування продуктивності";
        protected string method3 = "Регресійне тестування";
        protected string testMethod;

        public string TestMethod
        {
            get { return testMethod; }
            set {
                if (value != method1 && value != method2 && value != method3)
                {
                    Console.Write("Метод який ви використовуєте не використовується нашою команією");
                }
                else
                {
                    value = testMethod;
                }
            }
        }
    }
    public class TeamLead : Meneger
    {
        protected string TeamTask;
    }
}
