 /*Name: ADEYANJU Abdulsalam Tp
Department: Electrical-Electrical Engineering
Matric number: EES/18/19/0074
Course Code: EEG 323*/    
 using System;

namespace Jackson
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you a full-time or part-time student?");
            string student = Convert.ToString(Console.ReadLine());

            if (student == "full-time")
            {
                System.Console.WriteLine("What is your course of study?");
                string course = Convert.ToString(Console.ReadLine());
                Console.WriteLine(course + " is a good course.");

            }
            else if (student == "part-time")
            {
               Console.WriteLine("How many credits are you taking?");
               int credit = Convert.ToInt32(Console.ReadLine());

               if (credit > 6)
               {
                   
                   
                   Console.WriteLine("Too much units for a student");

               }
               else if (credit >=  6)

               {
                   Console.WriteLine("Proceed to screen");
               }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
