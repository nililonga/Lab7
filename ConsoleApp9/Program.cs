using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp9
{
    class Program
    {

        static void Main(string[] args)
        {  
            //have user put in name (1)
            Console.WriteLine("Please enter a valid name: ");
            //store user input into string (2)
            string TheName = (Console.ReadLine());
            //takes user input to static to perform action, stores value
           bool FinalName =  IsName(TheName);
            //perform conditions
            if (FinalName)
            {
                Console.WriteLine("Thanks for entering a valid name");
            }
            else
            {
                Console.WriteLine("That was not a valid name!");
            }
            //have user enter email
            Console.WriteLine("Please enter a valid email (yourname@whoever.com)");
            //store user input into string (2)
            string TheEmail = (Console.ReadLine());
            //takes user input to bool to perform action, stores value
            bool FinalEmail = IsEmail(TheEmail);
            //perform conditions
            if (FinalEmail)
            {
                Console.WriteLine("Valid Email!");
            }
            else
            {
                Console.WriteLine("Invalid Email!");
            }     
            //have user enter phone number
            Console.WriteLine("Please enter a valid phone number (123-123-1234): ");
            //store user input into string (3)
            string ThePhoneNumber = (Console.ReadLine());
            //takes user input to bool to perform action, stores value
            bool FinalPhoneNumber = IsPhoneNumber(ThePhoneNumber);
            //perform conditions
            if (FinalPhoneNumber)
            {
                Console.WriteLine("Valid Phone Number");
            }
            else
            {
                Console.WriteLine("Invalid Phone Number!");
            }
            //Have user enter date
            Console.WriteLine("Please enter the date ");
            //store user input into string (3)
            string TheDate = (Console.ReadLine());
            //takes user input to static boolto perform action, stores value
            bool FinalDate = IsDate(TheDate);
            //perform conditions
            if (FinalDate)
            {
                Console.WriteLine("Valid date!");
            }
            else
            {
                Console.WriteLine("Invalid date!");
            }
        }
        //take input and perform action (3)
        static bool IsName(string ValidName)
        {
            return (Regex.IsMatch(ValidName, "[A-Z]a*[a-z]{1,30}"));
        }
        //take input(2) and perform action
        static bool IsEmail(string ValidEmail)
        {
            return (Regex.IsMatch(ValidEmail, "\\w.{5,30}@\\w{5,10}.\\w{2,3} || \\w{5,30}@\\w{5,10}.\\w{2,3}"));
        }
        //take input(3) and perform action
        static bool IsPhoneNumber(string ValidPhoneNumber)
        {
            return (Regex.IsMatch(ValidPhoneNumber, "\\d{3}[-]\\d{3}[-]+\\d{4}")); 
        }
        //take input(4) and perform action
        static bool IsDate(string ValidDate)
        {
            return (Regex.IsMatch(ValidDate, "\\d[0-31]\\/\\d[0-12]\\/\\d[1900-2018]"));
        }
    }
}
