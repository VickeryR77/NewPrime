using System;
using System.Collections;
using System.Collections.Generic;

namespace PrimeLab
{

    public class PrimeNumbers 
    {
            public static void CreatePrimeList(ArrayList list)
            {
                int range = 100000;
                var numbers = new BitArray(range, true);
                //BitArray is a new type to me, you can set initial values which is great for moving something to false after we 
                //learn about it.

                //Not looking for 1 | Sieve algorithm

                for (int i = 2; i < range; i++)
                    if (numbers[i])
                    {
                        for (int j = i * 2; j < range; j += i)
                            numbers[j] = false;
                    }

                //Also not looking for 1
                int primeCount = 0;
                for (int i = 2; i < range; i++)
                    if (numbers[i])
                    {
                        primeCount++;
                        list.Add(i);
                        //If prime, add to list.
                    }
            }

            public static int GetPrime(ArrayList list, int choice)
            {
            return (int)list[choice-1];
            //Helps meet spec criteria, also easier to test this.
            }
        }

    
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            PrimeNumbers.CreatePrimeList(myList);

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Which prime number are you looking for?");
                bool isValid = int.TryParse(Console.ReadLine(), out int choice);
                while (!isValid || choice < 1)
                {
                    Console.WriteLine("Please enter a valid number greater than 0.");
                    isValid = int.TryParse(Console.ReadLine(), out choice);
                }
                Console.WriteLine($"The {choice} prime number is {PrimeNumbers.GetPrime(myList, choice)}");

                bool stillRunning = true;
                while (stillRunning)
                {
                    Console.WriteLine("Do you want to test another number? (Y/N)");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y")
                    {
                        break;
                    }
                    if (answer == "n")
                    {
                        Environment.Exit(1);
                    }
                    else
                    {
                        continue;
                    }
                }
            }



            

            
        }

        
    }
}
