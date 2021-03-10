using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToArrays
{
    class Program
    {
        static void PrintArray(int[] theArray)
        {
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.WriteLine("Index: " + i + " Number: " + theArray[i]);
            }
        }

        static void LoadArray(ref int[] theArray)
        {
            Random ranNumber = new Random();

            for (int i = 0; i < theArray.Length; i++)
            {
                theArray[i] = ranNumber.Next(10001);
            }
        }

        static void FindSmallest(ref int[] theArray)
        {
            //int smallest = 0;
            //bool notDone = true;

            //while (notDone)
            //{
            //    for (int i = 0; i < theArray.Length; i++)
            //    {
            //        if (theArray[i] == smallest)
            //        {
            //            Console.WriteLine("The smallest number is " + theArray[i])
            //        }
            //    }
            //}

            int smallest = theArray[0];
            
            for (int i = 0; i < theArray.Length; i++)
            {
                if (theArray[i] < smallest)
                {
                    smallest = theArray[i];
                }

            }

            Console.WriteLine("The smallest number is " + smallest);
        }

        static void Main(string[] args)
        {
            int[] listOfNumbers = new int[5];

            listOfNumbers[0] = 12;
            listOfNumbers[1] = 13;
            listOfNumbers[2] = 14;
            listOfNumbers[3] = 15;
            listOfNumbers[4] = 16;

            PrintArray(listOfNumbers);

            int[] moreNumbers = new int[1000];

            Console.WriteLine("Loading the big array...");
            LoadArray(ref moreNumbers);

            Console.WriteLine("Printing the big array...");
            PrintArray(moreNumbers);

            FindSmallest(ref moreNumbers);

            //string sentence = "The cow jumped over the moon";

            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    Console.WriteLine(sentence[i]);
            //}

            //Console.WriteLine(sentence.ToUpper());
            //Console.WriteLine(sentence.ToLower());
            //Console.WriteLine(sentence.Substring(4, 12));
        }
    }
}