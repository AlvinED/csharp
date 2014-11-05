using System;

namespace LoopsAndArrays
{
    public static class IOHelper
    {
        public static string AskQuestion(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int AskForNumber(string prompt)
        {
            return int.Parse(AskQuestion(prompt));
        }

        public static bool AskYesNoQuestion(string prompt)
        {
            string answer = AskQuestion(prompt).ToLower();
            return answer.Equals("y") || answer.Equals("yes");
        }
    }
}