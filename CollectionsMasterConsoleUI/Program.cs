using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] numbers = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Console.WriteLine("Hello, welcome to a program that displays interesting things with Arrays and Lists:");
            Console.WriteLine("-------Press enter------");
            Populater(numbers);
            Console.ReadLine();

            //Print the first number of the array
            Console.WriteLine();
            Console.WriteLine("This is the first number in the array:");
            Console.WriteLine(numbers[0]);
            Console.WriteLine("--------Press enter---------");
            //Print the last number of the array
            Console.ReadLine();
            Console.WriteLine("This is the last number in the array:");
            Console.WriteLine(numbers[49]);
            Console.WriteLine("------Press enter-----");
            Console.ReadLine();

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("---------Press enter----------");
            Console.ReadLine();

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(numbers);
            NumberPrinter(numbers);
            Console.ReadLine();
           

            Console.WriteLine("---------REVERSE CUSTOM------------");
            CustomReverse(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("--------Press enter-----------");
            Console.ReadLine();
            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);
            NumberPrinter(numbers);


            Console.WriteLine("----------Press enter---------");
            Console.ReadLine();
            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            List<int> numberList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine("On to Lists, Lets see what the capacity of our list is to start");
            Console.WriteLine(numberList.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Console.WriteLine("Press enter to populate the array with random integers:");
            Console.ReadLine();
            Populater(numberList);


            //Print the new capacity
            Console.WriteLine(numberList.Capacity);
            Console.WriteLine("^ This is our new capacity!");
            
            Console.WriteLine("----------Press enter-----------");
            Console.ReadLine();
            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            try
            {
                var userNum = int.Parse(Console.ReadLine());
                NumberChecker(numberList, userNum);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Please enter numbers only, Error message: {e.Message}");
            }
            


            Console.WriteLine("----------Press Emter---------");
            Console.ReadLine();
            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(numberList);
            Console.WriteLine("---------Press Enter----------");
            Console.ReadLine();
            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Odds Only!!");
            OddKiller(numberList);
            NumberPrinter(numberList);

            Console.WriteLine("--------Press Enter----------");
            Console.ReadLine();

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");
            numberList.Sort();
            NumberPrinter(numberList);

            Console.WriteLine("---------Press Enter---------");
            Console.ReadLine();
            //Convert the list to an array and store that into a variable
            Console.WriteLine("Now Ive converted this list to an Array, youll notice that all the changes to the list remain even after conversion!");
            int[] newArray = numberList.ToArray();
            NumberPrinter(newArray);
            Console.WriteLine("------Press Enter------");
            Console.ReadLine();

            //Clear the list
            Console.WriteLine("So that brings us to the end of the exercise, lets clear that list out since its no longer needed and print the number of elements inside.");
            Console.WriteLine("------Press Enter-------");
            Console.ReadLine();
            Console.WriteLine("This is the number of elements inside the list after clearing it!");
            numberList.Clear();
            Console.WriteLine(numberList.Count);
            Console.WriteLine("Isnt C# fun!!!!");

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(int j = 0; j < numbers.Length; j++)
            {
                if(numbers[j] % 3 == 0)
                {
                    numbers[j] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(i => i % 2 == 0);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            foreach (int num in numberList)
            {
                if(searchNumber == num)
                {
                    Console.WriteLine("That number exists in our list!");
                }
            }
            
        }

        private static void Populater(List<int> numberList)
        {
            numberList.Capacity = 50;
            Random rng = new Random();
            for(int i = 0; i < numberList.Capacity; i++)
            {
                numberList.Add(rng.Next(0, 50));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);

            }

        }

        private static void ReverseArray(int[] array)
        {

            Array.Reverse(array);
                
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        private static void CustomReverse(int[] CustomFlip)
        {
            for(int i = 0; i < CustomFlip.Length / 2; i++)
            {
                int tmp = CustomFlip[i];
                CustomFlip[i] = CustomFlip[CustomFlip.Length - i - 1];
                CustomFlip[CustomFlip.Length - i - 1] = tmp;
            }
        
        

        }
    }
}
