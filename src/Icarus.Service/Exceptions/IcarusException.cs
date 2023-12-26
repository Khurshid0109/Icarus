namespace Icarus.Service.Exceptions;

public class IcarusException : Exception
{
    public int StatusCode { get; set; }
    public IcarusException(int code, string message) : base(message)
    {
        StatusCode = code;
    }
}
