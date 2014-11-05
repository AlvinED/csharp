using System;

namespace Example1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names = new string[3];
            names[0] = "Donnie";
            names[1] = "Marian";
            names[2] = "Dave";

            string[] newNames = new string[4];

            for (int i = 0; i < 3; i++)
            {
                newNames[i] = names[i];
            }

            newNames[3] = "Kate";

            names = newNames;

            foreach (string s in names)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}