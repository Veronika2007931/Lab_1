
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
        public string LastName;
        private int age;

        // public Employee()
        // {
        //     Name = "Veronika";
        //     lastName = "Niema";
        //     Age = 18;
        //     Console.WriteLine("Employee: Викликано конструктор за замовчанням.");
        // }
         public Employee(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Console.WriteLine("Викликано конструктор з параметрами ");
        }
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

        public Meneger(string name, string lastName, int age) : base(name, lastName, age) 
    {
        
        Subordinates = 0; 
        Console.WriteLine("Meneger: Викликано конструктор з 3 аргументами.");
    }
       }
    

    public class Developer : Employee
    {
        protected string ProgrammingLanguage;

        public Developer(string name, string lastName, int age, string programmingLanguage):base(name,lastName,age)
        {
            this.ProgrammingLanguage = programmingLanguage;
            Console.WriteLine(" Викликано конструктор з параметрами.");
        }
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
                if (value == method1 || value == method2 || value == method3)
                {
                    testMethod = value;
                }
                else
                {
                    
                    throw new ArgumentException($"Метод '{value}' не використовується нашою компанією");
                }
            }
        }
    }
    public class TeamLead : Meneger
    {
        protected string TeamTask;
        // Статичне поле для зберігання єдиного екземпляру для приватного конструктора 
        private static TeamLead _instance;

        private TeamLead(string name, string lastName) : base(name, lastName, 40)
        {
            TeamTask = "Керування розробкою";
            Console.WriteLine($"TeamLead: Викликано приватний конструктор для {name}.");
        }
        
        public static TeamLead GetInstance(string name, string lastName)
        {
            if (_instance == null)
            {
                _instance = new TeamLead(name, lastName);
            }
            else
            {
                Console.WriteLine($"TeamLead: Екземпляр вже існує. Повертаємо {_instance.Name}.");
            }
            return _instance;
        }
    }
}
