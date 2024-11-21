using Lecture21.CustomAttributes;
using MiniBank.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Lecture21
{
    class Student
    {
        public string FirstName { get; set; }

        public DateTime StartDate { get; set; }

        [EndDateGreaterThanStartDate(nameof(StartDate))]
        public DateTime EndDate { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Student std1 = new()
            {
                FirstName = "Lana",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(1)
            };


            ValidationContext validationContext = new(std1);
            List<ValidationResult> results = new();

            bool isValid = Validator.TryValidateObject(std1, validationContext, results, true);



            //Type studentType = std1.GetType();
            //MethodInfo[] methods = studentType.GetMethods();
            //PropertyInfo[] properties = studentType.GetProperties();

            //DtoGenerator.GenerateDto(typeof(Account), "C:\\Users\\User\\Desktop\\IT STEP\\BCTSO-20-NC-2\\BCTSO-20-NC-2\\Lecture21\\Dtos\\");

        }

    }
}
