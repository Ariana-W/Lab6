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

            Console.WriteLine("This is the array we will use", newArrays);


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

                //Step 2: Determine how to move all constants before the first vowel to the end of the user input (lower)

                //USE A FOR LOOP THAT RUNS TO CHECK TO SEE IF EACH LETTER IN THE STRING IS A VOWEL OR NOT
                //USE BOOLEAN LOGIC TO HELP WITH THIS


                // Use a for loop to go through each point in the array to search for the vowel!

                for (int i = 0; i < newArrays.Length; i++)
                {
                    // Get character from array.
                    //I SHOULD SET MY I = TO A VARIABLE THAT REPRESENTS A VOWEL
                    char letter = newArrays[i];
                    // Display each letter.
                    Console.Write("Letter: ");
                    Console.WriteLine(letter);

                    

                    //Detect how to find the first  vowel in the user input 



                    // Use the index for the first value to remove the previous constanants 


                    //Assign those moved constanats to a new new string


                    //Add that new string (just created) to the end of whats left of the user input from the first vowel until the length of that array 



                    // Add "ay" to the end of all that



                }
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
