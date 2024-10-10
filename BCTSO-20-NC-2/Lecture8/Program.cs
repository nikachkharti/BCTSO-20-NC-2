using Lecture8.MiniBank.Models;

//1.მემკვიდრეობა +
//2.პოლიმორფიზმი (მრავალფორმიანობა) +
//3.ენკაფსულაცია +
//4.აბსტრაქცია +


public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public Person()
    {
    }

    public virtual void Talk() => Console.WriteLine($"Hello I am a Person {FirstName} {LastName} I am {Age} years old");
}
public abstract class Employee : Person
{
    public double Salary { get; set; }

    public Employee(string firstName, string lastName, int age, double salary) : base(firstName, lastName, age)
    {
        Salary = salary;
    }

    public Employee()
    {
    }

    public override void Talk() => Console.WriteLine($"Hello I am a Employee {FirstName} {LastName} I am {Age} years old I have salary {Salary} GEL");
}

public class Student : Person
{
    public double Score { get; set; }
    public Subject Subject { get; set; }

    public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
    }

    public Student()
    {
    }

    public override void Talk() => Console.WriteLine($"Hello I am a Student {FirstName} {LastName} I am {Age} years old I have subject {Subject.Title} and {Score} score");

}


public class Lecturer : Employee
{
    public Lecturer(string firstName, string lastName, int age, double salary) : base(firstName, lastName, age, salary)
    {
    }

    public Lecturer()
    {
    }
    public Subject Subject { get; set; }

    public override void Talk() => Console.WriteLine($"Hello I am a Student {FirstName} {LastName} I am {Age} years old I have subject {Subject.Title} and salary {Salary} GEL");
}

public class CEO : Employee
{
}

public class Subject
{
    public string Title { get; set; }
}









namespace Lecture8
{
    internal class Program
    {
        static void Main()
        {

            //Person personObj = new Person()
            //{
            //    FirstName = "Giorgi",
            //    LastName = "Giorgadze",
            //    Age = 18
            //};
            //personObj.Talk();

            //Employee employee = new Employee()
            //{
            //    FirstName = "Giorgi",
            //    LastName = "Menteshashvili",
            //    Age = 20,
            //    Salary = 1000
            //};
            //employee.Talk();

            //Student student = new Student()
            //{
            //    FirstName = "Nikoloz",
            //    LastName = "Kikiani",
            //    Age = 29,
            //    Score = 100,
            //    Subject = new Subject() { Title = "C#" }
            //};
            //student.Talk();

            //Lecturer lecturer = new()
            //{
            //    FirstName = "Nikoloz",
            //    LastName = "Chkhartishvili",
            //    Age = 29,
            //    Salary = 100,
            //    Subject = new Subject() { Title = "C#" }
            //};
            //lecturer.Talk();



            //SayHello(lecturer);



            //Animal tigerObject = new Tiger() { Name = "Tiger" };
            //Animal zebraObject = new Zebra() { Name = "Zebra" };
            //Animal lionObject = new Lion() { Name = "Lion" };



            #region MINI BANK
            Client client1 = new()
            {
                FirstName = "Vazha",
                LastName = "Vardiashvili",
                IdentityNumber = "12345678945",
                Account = new Account()
                {
                    Balance = 1000,
                    Currency = "GEL",
                    Iban = "0123456789601234567896"
                }
            };

            Account client2Account = new Account();
            client2Account.Currency = "GEL";
            client2Account.Balance = 1000;
            client2Account.Iban = "0123456789601234567899";

            Client client2 = new();
            client2.FirstName = "Saba";
            client2.LastName = "Beridze";
            client2.IdentityNumber = "98745612305";
            client2.Account = client2Account;

            try
            {
                client2.Account.Withdraw(7000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            //Console.WriteLine(client1.Account);
            //Console.WriteLine(client2.Account);


            //client1.Account.Transfer(client2.Account, 100);

            //Console.WriteLine("--------------");

            //Console.WriteLine(client1.Account);
            //Console.WriteLine(client2.Account);



            #endregion
        }


        public static void SayHello(Person person) => Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
        //public static void SayHello(Employee person) => Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
        //public static void SayHello(Student person) => Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
        //public static void SayHello(Lecturer person) => Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
    }
}
