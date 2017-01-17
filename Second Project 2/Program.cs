using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;

            while (stop == false)
            {
                Console.WriteLine("What is your first name?");
                string firstName = Console.ReadLine();
                if (firstName == "quit")
                {
                    break;
                }
                else if (firstName == "restart")
                {
                   continue;
                }

                Console.WriteLine("What is your last name?");
                string lastName = Console.ReadLine();

                if (lastName == "quit")
                
                {
                    break;
                }
                else if (lastName == "restart")
                {
                   continue;
                }

                string greet = FullName(firstName, lastName);
                Console.WriteLine(greet);

                Console.WriteLine("What is your age as a number");
                string yourAge = Console.ReadLine();
                
                if (yourAge  == "quit")
                {
                    break;
                }
                else if (yourAge  == "restart")
                {
                   continue;
                }
                int age = int.Parse(yourAge);

                Console.WriteLine("What is your birthmonth? Please enter a number value");
                string month = Console.ReadLine();
                int birthmonth = int.Parse(month);
                if (month == "quit")
                {
                    break;
                }
                else if (month == "restart")
                {
                    continue;
                }
                string vacHome = Convert.ToString(birthmonth);
                double pesos = RetireMoney(birthmonth);

                Console.WriteLine("What is you favorite RoyGBiv color? If you don't know RoyGBiv colors enter help");
                string color = Console.ReadLine();
                ColorMatch(color);
                if (color == "help")
                {
                    Console.WriteLine("RoyGBiv colors are red, orange, yellow, green, blue, indigo, and violet. Enter color again");
                    color = Console.ReadLine();
                }

                else if (color == "quit")
                {
                    break;
                }
                else if (color == "restart")
                {
                    continue;
                }
                color.ToUpper();

                string transpo = ColorMatch(color);
                Console.WriteLine("How many siblings do you have?");
                int siblings = int.Parse(Console.ReadLine());
                string finalHome = FamSize(siblings);
                int retireYears = YearsToRetire(age);

                Console.Write(firstName + " " + lastName + " you will retire in " + retireYears + "years with $" + pesos + " in the bank, a vacation home in " + finalHome + " and a " + transpo + " ");
                FortuneTeller();
                stop = true;

            }
        }
        static string FullName(string firstName, string lastName)
        {
            string greet = "Greetings, " + firstName + " " + lastName + "."+ " I will tell you your fortune.";
            return greet;
        }
        static string FamSize(int siblings)
        {
            string vacHome = "";

            if (siblings == 0)
            {
                vacHome = "Florida";
            }
            else if (siblings == 1)
            {
                vacHome = "Cancun";
            }
            else if (siblings == 2)
            {
                vacHome = "Mexico";
            }
            else if (siblings == 3)
            {
                vacHome = "China";
            }
            else if (siblings > 3)
            {
                vacHome = "London";
            }
            else if (siblings <= 0)
            {
                vacHome = "Slums of Detroit";
            }
            return vacHome;

        }
        static int YearsToRetire(int age)
        {
            
            int retireYears;
            if (age % 2 == 0)
            {
                retireYears = 20;
            }
            else
            {
                retireYears = 30;
            }
            return retireYears;
        }
        static string ColorMatch(string color)
        {
            color = color.ToLower();
            string transpo = "";
            if (color == "red" || color == "orange" || color == "yellow" || color == "green" || color == "blue" || color == "inigo" || color == "violet")
                switch (color)
                {
                    case "red":
                        transpo = "Rolls Royce";
                        break;
                    case "orange":
                        transpo ="Yacht";
                        break;
                    case "yellow":
                        transpo ="Harley Davidson";
                        break;
                    case "green":
                        transpo = "Private Jet";
                        break;
                    case "blue":
                        transpo = "Horse";
                        break;
                    case "indigo":
                        transpo = "Canoe";
                        break;
                    case "violet":
                        transpo = "Helicopter";
                        break;
                    default:
                        transpo = "pair of tennis shoes for walking";
                        break;
                }
            return transpo;
        }
        static double RetireMoney(int birthmonth)
        {
            double pesos;

            if (birthmonth >= 1 && birthmonth <= 4)
            {
                pesos = 1000000.00;
            }
            else if (birthmonth >= 5 && birthmonth <= 8)
            {
                pesos = 5000000.00;
            }
            else if (birthmonth >= 9 && birthmonth <= 12)
            {
                pesos = 2000000.00;
            }
            else
            {
                pesos = 00.00;
            }
            return pesos;
        }
        static void FortuneTeller()
        {
            Console.WriteLine("That's a good fortune for someone like you.");
        }
       
    }
}
