namespace University.Service.Exceptions
{
    public class AmbigousNameException : Exception
    {
        public AmbigousNameException() : base($"Ambigous name occured")
        {
        }
    }
}
