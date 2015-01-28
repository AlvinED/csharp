using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            char middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCm;

            firstName = "Donnie";
            middleInitial = 'J';
            lastName = "Santos";
            fullName = firstName + " " + middleInitial + ". " + lastName;

            age = 36;
            heightFeet = 6;
            heightInches = 1.25;
            double totalInches = heightFeet * 12 + heightInches;
            totalHeightCm = 2.54 * totalInches;

            isCitizen = true;
            bool isOldEnoughToVote = age >= 18;
            canVote = isCitizen && isOldEnoughToVote;
        }
    }
}