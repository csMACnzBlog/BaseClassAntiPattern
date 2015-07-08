using System;

namespace BaseClassProblem.BusinessLayer
{
    public interface IAuthenticationService
    {
        void Authenticate();
    }

    public class AuthenticationService : IAuthenticationService
    {
        public void Authenticate()
        {
            Console.WriteLine("Authenticated");
        }
    }
}
