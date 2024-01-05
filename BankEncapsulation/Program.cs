namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();

            Console.WriteLine("Press 1. to deposit money.");
            Console.WriteLine("Press 2. to check your account balance.");
            var userInput = Console.ReadLine();

            if(userInput == "1")
            {
                Console.WriteLine("How much money would you like to deposit:");
                var depositAmount = Convert.ToDouble(Console.ReadLine());
                myAccount.Deposit(depositAmount);
                Console.WriteLine($"Your new account balance is {myAccount.GetBalance()}.");
            }
            else if (userInput == "2")
            {
                Console.WriteLine($"Your account balance is {myAccount.GetBalance()}.");
            }
            else
            {
                Console.WriteLine("Please choose one of the options by pressing either 1. or 2.");
            }
        }
    }
}


//        In your BankAccount class, create the following:
//A private field of type double named **balance** with a value of 0
//Define a method named Deposit that will accept a double and store that value in the balance field
//Define a method named GetBalance that will return the amount stored in the balance field
//In the main method of your application, create a new instance of the BankAccount class. Allow the user of the application to Deposit money and retrieve their balance through the console.
//Once finished save, commit, and push back to Github