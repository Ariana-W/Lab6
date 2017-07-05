using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab6
{
    class Program
    {

        static void Main(string[] args)

        {

            string result;


            // Ask user to type in a word 

            Console.WriteLine("Hello Welcome to the World of Different Languages!");
            Console.WriteLine();

            Console.WriteLine("Can you please enter a word? As long of a word as you'd like!");
            result = Console.ReadLine();

            Console.WriteLine();

            //Specification 1: 

            //Convert the user input into all lowercase letters 

            string lower = result.ToLower();

            //Console.WriteLine(lower);

            Console.WriteLine();


            //Specification 2: 

            // Search for vowels and if there is a word with a vowel in the beggining add the word way at the end of it 

            //Step 1: How to search for vowels?

            //Solution: Create an array that way we can have an address for each char from the user input 


            Console.WriteLine();

            Console.WriteLine();

            // Step 2: If statement that detects a vowel at the beginning of a word 
            // Solution: Use boolean logic to say if something is == to what the user inputs! 



            string sub = lower.Substring(0, 1);


            if (sub == "a" || sub == "e" || sub == "i" || sub == "o" || sub == "u" || sub == "A" || sub == "E" || sub == "I" || sub == "O" || sub == "U")

            //Step 3: Add the word "way" to the end of word

            //Solution: Create an if statement or while loop that says while or if the word begins with certaion conditions
            // (a vowel at the beginning) then add way to the end of it!
            {
                Console.WriteLine(lower + "-way");
            }

            // Specification 3: 
            /* If a word starts with a constanant, move all of the constanats that appear before 
             the first vowel to the end of the word, then add ay to the end of it */

            char[] newArrays = lower.ToCharArray();

            //Step 1: Determine how the program will detect a constanat 
            if (sub != "a" || sub != "e" || sub != "i" || sub != "o" || sub != "u" || sub != "A" || sub != "E" || sub != "I" || sub != "O" || sub != "U")
            {
                // We need a for loop that is running and checking to constantly see where the vowel is located in user input

                for (char i = newArrays[0]; i < newArrays.Length; i++)
                {
                    char[] theVowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

                    foreach (char item in newArrays = theVowels)
                    {
                        //THIS ONLY WORKS IF THE STRING CONSTAINS AN 'x'... 
                        //Goal: To find out how to check for multiple vowels within the for loop 

                        int x = lower.IndexOf('x');

                        // Leaves the rest of the string starting at the vowel

                        string d = lower.Substring(x);

                        // A varaible for the constanats that will be moved before the first vowel
                        string h = lower.Substring(0, x);

                        // I am trying to print out the letters that will be moved before the first vowel           

                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine(d + h + "-ay");


                    }
                }



            }



           

        }
            //BELOW ARE NOTES OF A FEW OF THE ATTEMPTS I MADE TO TRY AND SOLVE THIS PROBLEM! But not all of my attempta



            // 6TH ATTEMPT AT PART 3

            // A varaible for the constanats that will be moved before the first vowel
            // string h = lower.Substring(0, x);


            // (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u' || i == 'A' || i == 'E' || i == 'I' || i == 'O' || i == 'U')
            // )
            /*
            int x = lower.IndexOf(newArrays[i]);

            string d = lower.Substring(i);


            // A varaible for the constanats that will be moved before the first vowel
            string h = lower.Substring(0, i);

            // I am trying to print out the letters that will be moved before the first vowel           

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(d + h + "-ay");

    
        

            /*

            if
          (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u' || i == 'A' || i == 'E' || i == 'I' || i == 'O' || i == 'U')
          */
            //{
            //The below line is in important because it needs to connect to know where the cutt off point should be
            /*
            string d = lower.Substring(i);


            // A varaible for the constanats that will be moved before the first vowel
            string h = lower.Substring(0, i);

            // I am trying to print out the letters that will be moved before the first vowel           

            Console.WriteLine();
            Console.WriteLine();



//  5TH ATRTEMPT AT SPECIFICATION 3 

        // bool checkingForVowels = theVowels.Any(newArrays.Contains);

                    /*
                     * if (checkingForVowels == true) */ 
                    {


                        // int x = lower.IndexOf(newArrays[i]);



        //FOURTH ATTEMPT AT SPECIFICATION 3 



        /* int x = lower.IndexOf('a');

            // Leaves the rest of the string starting at the vowel

            string d = lower.Substring(x);

            // A varaible for the constanats that will be moved before the first vowel
            string h = lower.Substring(0, x);
               
            // I am trying to print out the letters that will be moved before the first vowel           

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(d + h + "-ay");
            */


        // THIRD ATTEMPT AT SPECIFICATION 3


        // Trying to connect the array to a list of vowels, to use as a checking measure to determine if there is a vowel
        // foreach (char in newArrays == vowelList[0])


        // SECOND ATTEMPT AT PART 3 
        /*
              for (char i = newArrays[0]; i<newArrays.Length; i++)

              {
                  foreach (char value in newArrays)
                  {
                      if
                   (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u' || i == 'A' || i == 'E' || i == 'I' || i == 'O' || i == 'U')

                      {
                          int x = lower.IndexOf(i);

        // Leaves the rest of the string starting at the vowel

        string d = lower.Substring(x);

        // A varaible for the constanats that will be moved before the first vowel
        string h = lower.Substring(0, x);

        // I am trying to print out the letters that will be moved before the first vowel           

        Console.WriteLine();
                          Console.WriteLine();

                          Console.WriteLine(d + h + "-ay");






             }
        }

        */

    }
}








    