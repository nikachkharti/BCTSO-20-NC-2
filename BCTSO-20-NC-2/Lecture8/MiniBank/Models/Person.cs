namespace Lecture8.MiniBank.Models
{
    public class Person
    {
        private string identityNumber;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber
        {
            get { return identityNumber; }
            set
            {
                if (value.Trim().Length == 3)
                {
                    identityNumber = value;
                }
            }
        }
    }
}
