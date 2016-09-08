using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003._1
{
    class AgeDistribution
    {
        static void Main(string[] args)
        {
            //declare variable
            int userAge;

            //ask and get user's age
            Console.WriteLine("How old are you?");
            userAge = int.Parse(Console.ReadLine());

            //conditional based on user's age
            if ((userAge >= 0) && (userAge <= 2))
            {
                Console.WriteLine("Still in momma's arms");
            }
            else if ((userAge >= 3) && (userAge <= 4))
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if ((userAge >= 5) && (userAge <= 11))
            {
                Console.WriteLine("Elementary School");
            }
            else if ((userAge >= 12) && (userAge <= 14))
            {
                Console.WriteLine("Middle School");
            }
            else if ((userAge >= 15) && (userAge <= 18))
            {
                Console.WriteLine("High School");
            }
            else if ((userAge >= 19) && (userAge <= 22))
            {
                Console.WriteLine("College");
            }
            else if ((userAge >= 23) && (userAge <= 65))
            {
                Console.WriteLine("Working for the Man");
            }
            else if ((userAge >= 66) && (userAge <= 100))
            {
                Console.WriteLine("The Golden Years");
            }
            else if ((userAge < 0) || (userAge > 100))
            {
                Console.WriteLine("This program is for humans");
            }
            Console.ReadKey();
        }
    }
}
