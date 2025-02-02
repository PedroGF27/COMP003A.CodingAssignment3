//Pedro Garcia
//COMP003A
//Johnathan Cruz
//Lecture Activity 3-3
using System.Reflection.Metadata.Ecma335;

namespace COMP003A.CodingAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double userIncome;

            
            Console.Write("Enter your montly income: "); // prompt to add income
            userIncome = double.Parse(Console.ReadLine());

            string[] expenses = new string[5]; // to hold 5 expense names
            double[] amounts = new double[5]; // to hold 5 expences
            
            bool exit = false; // control the loop
            while (exit) // ensure it keeps going till user exit's
            {

                Console.WriteLine("1. Add an expense\n2. View expenses"); // display options
                Console.WriteLine("3. Remove an Expense\n4. Exit"); // display options
                Console.Write("Choose an option: ");

                int number;
                try
                {
                    number = Convert.ToInt32(Console.ReadLine()); // converts to an integer
                }
                catch
                {
                    Console.WriteLine("Error, add a number 1-4"); // error message
                    continue;
                }

            }
        }
    }
}
