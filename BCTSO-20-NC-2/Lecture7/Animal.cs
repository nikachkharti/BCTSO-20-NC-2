namespace Lecture7
{
    public class Animal
    {
        public string Name { get; set; }

        //ენკაფსულაცია
        private byte legs;
        public byte Legs
        {
            get { return legs; }
            set
            {
                if (value <= 8)
                {
                    legs = value;
                }
            }
        }


    }
}
