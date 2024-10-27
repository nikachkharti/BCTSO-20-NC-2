namespace Lecture14
{
    interface TestInterface<T> /*where T : class*/
    {
        T ReturnType();
    }

    public class Person : TestInterface<int> /*where T : class*/
    {
        public int ReturnType()
        {
            throw new NotImplementedException();
        }
    }
}
