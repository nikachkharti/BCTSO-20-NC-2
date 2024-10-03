namespace Lecture7
{
    //public private internal

    public class Person
    {
        //Auto property
        public string FirstName { get; set; }

        //Auto property
        public string LastName { get; set; }


        //Full Property 
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }




        //public void SetAge(int value)
        //{
        //    if (value > 0)
        //    {
        //        age = value;
        //    }
        //}

        //public int GetAge()
        //{
        //    return age;
        //}




        #region ფუნქცია


        //კონსტრუქტორი 2
        //public Person()
        //{
        //}



        ////კონსტრუქტორი 1
        //public Person(string firstName, string lastName, int age)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    this.age = age;
        //}

        ////კონსტრუქტორი 3
        //public Person(int age)
        //{
        //    this.age = age;
        //}

        //მეთოდი
        public void Talk()
        {
            Console.WriteLine($"Hello my name is {FirstName} {LastName} I am {Age} years old");
        }
        #endregion
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            //წერტილებით
            Person firstPerson = new Person(); //კონსტრქუტორი
            firstPerson.FirstName = "Nikolozi";
            firstPerson.LastName = "Kikiani";
            firstPerson.Age = 12;



            Console.WriteLine($"{firstPerson.FirstName} {firstPerson.LastName} {firstPerson.Age}");


            Animal zebraObj = new Animal();
            //zebraObj.Name = "Zebra";
            //zebraObj.Legs = 4;


            Animal octopusObj = new Animal()
            {
                Legs = 8,
                //Name = "Octopus"
            };



            ////ფროფერთის ინიცლიაზატორი
            //Person secondPerson = new Person() //კონსტრქუტორი
            //{
            //    firstName = "Lana",
            //    lastName = "Stin",
            //    age = 19
            //};

            //Console.WriteLine($"{firstPerson.firstName} {firstPerson.lastName} {firstPerson.age}");

        }

    }
}
