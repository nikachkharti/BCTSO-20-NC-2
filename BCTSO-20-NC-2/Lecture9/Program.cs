namespace Lecture9
{
    #region INTERFACES ABSTRACTS

    interface ITestInterface
    {
        void Test()
        {
            Console.WriteLine("DEFAULT");
        }
    }

    class Test : ITestInterface
    {
    }

    abstract class Animal
    {
        public string Name { get; set; }
        public abstract void MakeVoice();
    }

    class Tiger : Animal
    {
        public override void MakeVoice()
        {
            throw new NotImplementedException();
        }
    }

    class Zebra : Animal
    {
        public override void MakeVoice()
        {
            throw new NotImplementedException();
        }
    }

    class Lion : Animal
    {
        public override void MakeVoice()
        {
            throw new NotImplementedException();
        }
    }


    public abstract class Bird
    {
        public string Name { get; set; }
        public int WingsCount { get; set; } = 2;
    }

    public interface IFlyer
    {
        public void Fly();
    }

    public interface IFlyer2
    {
        public void Fly();
    }

    public class Eagle : Bird, IFlyer, IFlyer2
    {

        void IFlyer.Fly()
        {
            throw new NotImplementedException();
        }

        void IFlyer2.Fly()
        {
            throw new NotImplementedException();
        }
    }

    public class Penguin : Bird
    {
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            //ITestInterface t = new Test();
            //t.Test();

            //Console.WriteLine("Hello, World!");

            //IFlyer flyerObject = new Eagle();

        }
    }
}
