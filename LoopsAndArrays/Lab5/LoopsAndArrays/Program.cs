using System;

namespace LoopsAndArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GroupOfPeople group = new GroupOfPeople();

            while (IOHelper.AskYesNoQuestion("Do you want to add another person to the array? "))
            {
                // TODO : Add A Person to the Group
            }

            // TODO : Diplay All People

            Console.Write("Press any key to end the program... ");
            Console.ReadKey();
        }
    }
}