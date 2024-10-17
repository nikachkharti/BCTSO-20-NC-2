namespace Algorithms.Models
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public byte Cylinder { get; set; }
        public float Engine { get; set; }
        public string Drive { get; set; }
        public string Transmission { get; set; }
        public byte City { get; set; }
        public byte Combined { get; set; }
        public byte Highway { get; set; }

        public static Vehicle Parse(string value)
        {
            string[] csvValue = value.Split(',');

            if (csvValue.Length != 9)
            {
                throw new ArgumentException("Incorrect argument passed");
            }

            Vehicle result = new()
            {
                Make = csvValue[0],
                Model = csvValue[1],
                Cylinder = byte.Parse(csvValue[2]),
                Engine = float.Parse(csvValue[3]),
                Drive = csvValue[4],
                Transmission = csvValue[5],
                City = byte.Parse(csvValue[6]),
                Combined = byte.Parse(csvValue[7]),
                Highway = byte.Parse(csvValue[8])
            };

            return result;
        }
    }
}
