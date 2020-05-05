using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            //Building Damnit
            Console.WriteLine("Converter");
            Console.WriteLine("Converter");


            // Account Information

            int accountNumber = 11182019;
            int pinNum = 0504;
            decimal initialBalance = 5000.00m;
            decimal deposits = 0.00m;
            decimal withdraws = 0.00m;
            decimal transactionAmount = 0.00m;
            decimal accountBalance = (initialBalance + transactionAmount);


            Console.WriteLine("Welcome to \"THE CONVERTER\" DAMNIT! \nPlease Enter Your Name! ");
            string userName = (Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Welcome {userName}");

            // Authorization Account Number
            int attempts = 0;

            do
            {

                Console.WriteLine("Please Enter Your 8 Digit Account Number:");
                int passwordAnswer = Convert.ToInt32(Console.ReadLine());

                if (passwordAnswer == accountNumber)
                    break;


                else if (passwordAnswer != accountNumber)


                    Console.WriteLine($"{userName} That was not correct. Please try again.");
                attempts++;

                if (attempts % 3 == 0)
                {

                    Console.WriteLine("Here is a HINT: \nDay this Class started. \nDamnit!");

                }

            } while (true);

            Console.Clear();

            // Authorization PIN Number

            Console.WriteLine($"Thank You {userName}");


            int pinAttempts = 0;

            do
            {

                Console.WriteLine("Please Enter Your 4 Digit PIN Number:");
                int pinAnswer = Convert.ToInt32(Console.ReadLine());

                if (pinAnswer == pinNum)
                    break;


                else if (pinAnswer != pinNum)


                    Console.WriteLine($"{userName} That was not correct. Please try again.");
                pinAttempts++;

                if (pinAttempts % 3 == 0)
                {

                    Console.WriteLine("Here is a HINT: \nMay WHAT?");
                }

            } while (true);


            Console.Clear();

            // Menu for Deposits, Withdraws, and Check Ballance

            Console.WriteLine("**************MENU****************");
            System.Threading.Thread.Sleep(2500);

            bool repeat = true;

            do
            {
                Console.WriteLine("D)eposit \nW)ithdraw \nC)heck Balance \nE)xit");
                ConsoleKey userChoice = Console.ReadKey().Key;
                Console.Clear();

                switch (userChoice)
                {
                    //Check Balance
                    case ConsoleKey.C:

                        Console.WriteLine($"{accountBalance:c}");

                        break;

                    //Make Deposit
                    case ConsoleKey.D:
                        Console.WriteLine("Enter the amount you want to Deposit: ");
                        deposits = decimal.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"You have deposited {deposits:c}");
                        transactionAmount = (deposits - withdraws);
                        accountBalance = (initialBalance + transactionAmount);

                        break;

                    //Make Withdraw
                    case ConsoleKey.W:
                        Console.WriteLine("Enter the amount you want to Withdraw: ");
                        withdraws = decimal.Parse(Console.ReadLine());
                        if (withdraws < accountBalance)
                        {
                            transactionAmount = (deposits - withdraws);
                            accountBalance = (initialBalance + transactionAmount);
                            Console.Clear();
                            Console.WriteLine($"You have withdrawn {withdraws:c}");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Try a smaller amount!");
                            Console.Write("");
                        }


                        break;

                    //Exit System
                    case ConsoleKey.E:
                        repeat = false;
                        break;

                }


            } while (repeat);

            Console.WriteLine("Thank You For Your Business!\nGOOD BYE");










        }
    }
}