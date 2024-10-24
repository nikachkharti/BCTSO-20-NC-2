namespace Lecture13
{
    public delegate void LoggingDelegate(string message);

    internal class Program
    {
        static void Main(string[] args)
        {
            //დაწერეთ ლოგერი რომელიც არგუმენტად მიიღებს დელეგატს, და გადაცემული დელეგატის ფუნქციის მიხედვით
            //განისაზღვრება ლოგირება მოხდეს ფაილში თუ ჩაწერა მოხდეს კონსოლში.

            Log("Hello World!", LogInConsole);
        }

        public static void Log(string message, LoggingDelegate loggingDelegate)
        {
            loggingDelegate(message);
        }


        // კონკრეტული ფუნქციები
        private static void LogInFile(string message)
        {
            File.WriteAllText(@"../../../TestLogger.txt", message);
        }
        private static void LogInConsole(string message)
        {
            Console.Write(message);
        }
    }
}
