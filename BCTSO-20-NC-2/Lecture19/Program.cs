using System.Text;

namespace Lecture19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string filePath = "../../../test.txt";


            //StreamWriter ფაილში ჩაწერა
            //using (StreamWriter sw = new StreamWriter(filePath,append:true))
            //{
            //    sw.WriteLine("Hello Lana");
            //}


            //StreamReader ფაიილს წაკითხვა
            //using (StreamReader sr = new(filePath))
            //{
            //    var content = sr.ReadToEnd();
            //}


            //FileStream ფაილში ჩაწერა
            //try
            //{
            //    using (FileStream fileStreamWriter = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            //    {
            //        byte[] data = Encoding.UTF8.GetBytes("Hello World");
            //        fileStreamWriter.Write(data, 0, data.Length);

            //        Console.WriteLine("Data written in file.");

            //    }// თავისით გამოიძახოს Dispose
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



            //FileStream ფაილის წაკითხვა
            //try
            //{
            //    using (FileStream fileStreamReader = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            //    {
            //        byte[] buffer = new byte[fileStreamReader.Length];
            //        fileStreamReader.Read(buffer, 0, buffer.Length);
            //        string realData = Encoding.UTF8.GetString(buffer);

            //        Console.WriteLine(realData);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

        }
    }
}
