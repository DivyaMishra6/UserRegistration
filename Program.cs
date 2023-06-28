namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Page!!");
            Console.WriteLine("********************************");

            Registration obj = new Registration();
            //Console.WriteLine("Enter the First Name:");
            //string FName = Console.ReadLine();
            //Console.WriteLine("Enter the Last Name:");
            //string LName = Console.ReadLine();
            ////Console.WriteLine("Enter your Email Id:");
            ////string MailId = Console.ReadLine();
            //Console.WriteLine("Enter your Mobile Number:");
            //string MobNum = Console.ReadLine();
            //Console.WriteLine("Enter your password:");
            //string password = Console.ReadLine();


            //Console.WriteLine(obj.ValidateFName(FName));
            //Console.WriteLine(obj.ValidateFName(LName));
            ////Console.WriteLine(obj.ValidateEmail(MailId));
            //Console.WriteLine(obj.ValidateMobNum(MobNum));
            //Console.WriteLine(obj.ValidatePassword(password));

            Console.WriteLine("Enter your Email Id:");
            string MailId = Console.ReadLine();

            string[] emailSamples = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };

            foreach (string email in emailSamples)
            {
                Console.WriteLine("{0} : {1}", email, obj.ValidateEmail(MailId) ? "Valid" : "Invalid");
            }
        }
    }
}