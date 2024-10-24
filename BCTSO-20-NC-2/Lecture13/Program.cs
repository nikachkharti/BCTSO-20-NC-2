namespace Lecture13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //დაწერეთ ლოგერი რომელიც არგუმენტად მიიღებს დელეგატს, და გადაცემული დელეგატის ფუნქციის მიხედვით
            //განისაზღვრება ლოგირება მოხდეს ფაილში თუ ჩაწერა მოხდეს კონსოლში.
        }

        public void Log(string message, LogInConsole)
        {
            throw new NotImplementedException();
        }

        public static void LogInFile(string message)
        {
            throw new NotImplementedException();
        }

        public static void LogInConsole(string message)
        {
            throw new NotImplementedException();
        }
    }
}
