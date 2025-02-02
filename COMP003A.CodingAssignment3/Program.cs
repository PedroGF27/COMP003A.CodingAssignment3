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

                switch (number)
                {
                    case 1:
                        int index = Array.FindIndex(expenses, name => name == null); // First empty index
                        if (index == -1) // checks if array is full
                        {
                            Console.WriteLine("Maximum amount of expenses added."); // display when array if filled
                            break;
                        }
                        

                        Console.Write("Expense name: "); // prompt for expense name
                        expenses[index] = Console.ReadLine(); // store the name

                        try
                        {
                            Console.Write("Expense amount: ");
                            amounts[index] = Convert.ToDouble(Console.ReadLine());
                            if (amounts[index] <= 0) // check if amount entered is positive
                            {
                                throw new ArgumentException("Must be positive number."); // throws exception if invalid

                            }
                        }
                        catch (Exception ex) // catch exceptions
                        {
                            Console.WriteLine($"Error: {ex.Message}. Not added"); // display error message
                            expenses[index] = null; // clear if invalid
                        }
                        break;

                    case 2:
                        double totalExpenses = 0;

                        Console.WriteLine("All Expenses:"); 
                        for (int i = 0; i < expenses.Length; i++) // loop through array
                        {
                            if (expenses[i] != null) // checks if expenses are null
                            {
                                Console.WriteLine($"{expenses[i]}: ${amounts[i]}"); // display expense name and amount
                                totalExpenses += amounts[i]; // add to expenses
                            }
                        }
                        double remaining = userIncome - totalExpenses; //  calculate remaining budget

                        Console.WriteLine($"Total Expenses: ${totalExpenses}"); // display total expenses
                        Console.WriteLine($"Remaining budget: ${remaining}"); // display remaining budget
                        break;
                    case 3:
                        Console.Write("Name of expense you want to remmove: "); // Prompt to write name of expense user wants removed
                        string expenseRemoval = Console.ReadLine(); 
                        int indexRemoval = Array.FindIndex(expenses, name => name == expenseRemoval); // find index of expense name
                        if (indexRemoval != -1) // checks if expense is found
                        {
                            expenses[indexRemoval] = null; // clear expense name
                            amounts[indexRemoval] = 0; // clear amount
                            Console.WriteLine("Removed."); // display to notify it is removed
                        }
                        else
                        {
                            Console.WriteLine("Not found, Try again."); // If not found, message is displayed
                        }
                        break;
                    case 4:
                        exit = true;// set to true to end program.
                        Console.WriteLine("Leaving Program"); // display message to exit
                        break;
                    default:
                        Console.WriteLine("Invalid, Please try again."); // Display error message 
                        break;

                        

                            
                        
                }

            }
        }
    }
}
