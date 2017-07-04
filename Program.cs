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

            char[] newArrays = lower.ToCharArray();

         
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


            //Step 1: Determine how the program will detect a constanat 
            if (sub != "a" || sub != "e" || sub != "i" || sub != "o" || sub != "u" || sub != "A" || sub != "E" || sub != "I" || sub != "O" || sub != "U")
            {
                // Step 2: Figure out how to find the first vowel from the user input   


                int i = lower.IndexOf('a');

                
            

                // Leaves the rest of the string starting at the vowel

                string d = lower.Substring(i);

                // A varaible for the constanats that will be moved before the first vowel
                string h = lower.Substring(0, i);

                // I am trying to print out the letters that will be moved before the first vowel           

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine(d + h + "-ay");
                // Use a for loop that will run the above code until it finds the first vowel 



                // Use a for loop to go through each point in the array to search for the vowel!
                /*

                for (int i = 0; i < newArrays.Length; i++)
                {
                    // Get character from array.
                    //I SHOULD SET MY I = TO A VARIABLE THAT REPRESENTS A VOWEL
                    char letter = newArrays["a"];
                    // Display each letter.
                    Console.Write("Letter: ");
                    Console.WriteLine(letter);

                    */

            }
        }
    



        //Create a Method That is for testing 

        static int FailSafe()
        {
            return 0;

            //If the user does not enter a vowel for the 2nd specification.. ask user to try again and display 
            // "You have one more try" and if not the computer says goodbye and then breaks and after 1 try the computer says goodbye and then it breaks!


            //If the user does pick a vowel for the 3rd condition then ask the user to try again and display you have two more tries 
        }
    }



}
