namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Page!!");
            Console.WriteLine("********************************");
            Registration obj = new Registration();
            Console.WriteLine("Enter the First Name:");
            string FName = Console.ReadLine();
            Console.WriteLine(obj.ValidateFName(FName));
        }
    }
}