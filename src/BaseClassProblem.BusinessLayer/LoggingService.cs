using System;

namespace BaseClassProblem.BusinessLayer
{
    public interface ILoggingService
    {
        void Log(string message);
    }

    public class LoggingService : ILoggingService
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged Message: \"{0}\"", message);
        }
    }
}
