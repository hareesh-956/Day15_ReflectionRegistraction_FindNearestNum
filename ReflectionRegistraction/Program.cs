namespace ReflectionRegistraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistration registration = new UserRegistration();
            string firstName = "Hareesh";
            string lastName = "Vanapalli";
            string email = "hareeshvanapalli956@gmail.com";
            string mobile = "91 9705220956";
            string password = "P@ssw0rd123";

            // Test each validation rule using reflection.
            bool isValidFirstName = registration.ValidateAllRules(registration, "ValidateFirstName", firstName);
            bool isValidLastName = registration.ValidateAllRules(registration, "ValidateLastName", lastName);
            bool isValidEmail = registration.ValidateAllRules(registration, "ValidateEmail", email);
            bool isValidMobile = registration.ValidateAllRules(registration, "ValidateMobile", mobile);
            bool isValidPassword = registration.ValidateAllRules(registration, "ValidatePassword", password);

            Console.WriteLine("First Name is Valid: " + isValidFirstName);
            Console.WriteLine("Last Name is Valid: " + isValidLastName);
            Console.WriteLine("Email is Valid: " + isValidEmail);
            Console.WriteLine("Mobile is Valid: " + isValidMobile);
            Console.WriteLine("Password is Valid: " + isValidPassword);
        }
    }
}