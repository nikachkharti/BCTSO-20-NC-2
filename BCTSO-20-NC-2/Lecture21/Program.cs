using MiniBank.Models;
using System.Reflection;

namespace Lecture21
{
    class Student
    {
        public string FirstName { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //Student std1 = new()
            //{
            //    FirstName = "Lana"
            //};

            //Type studentType = std1.GetType();
            //MethodInfo[] methods = studentType.GetMethods();
            //PropertyInfo[] properties = studentType.GetProperties();

            DtoGenerator.GenerateDto(typeof(Account), "C:\\Users\\User\\Desktop\\IT STEP\\BCTSO-20-NC-2\\BCTSO-20-NC-2\\Lecture21\\Dtos\\");

        }

    }
}
