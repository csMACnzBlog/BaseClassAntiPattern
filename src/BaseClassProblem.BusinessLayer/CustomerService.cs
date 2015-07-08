namespace BaseClassProblem.BusinessLayer
{
    public interface ICustomerService
    {
        string GetCustomerDetails();
        string GetCustomerDashboardDisplay();
    }

    public class CustomerService : ICustomerService
    {
        public string GetCustomerDetails()
        {
            return "Bob's Details";
        }

        public string GetCustomerDashboardDisplay()
        {
            return "Bob";
        }
    }
}
