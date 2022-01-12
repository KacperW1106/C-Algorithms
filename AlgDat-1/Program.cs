using System;
using System.Linq;

namespace AlgDat_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************\n\nOblig 1 in alogrithms and datastructures\n\nMade by Kacper W. in C# \n\n*************\n\n");
            int[] a1 = {10000, 1, 65, 1, 3, 73, 73, 55, 88, 99, 11, 99, 1};
            int[] a2 = { 1, 2, 3, 3, 3, 8, 10, 11 };
            int[] a3 = { 3, 2, 1, 3 };
            char[] a4 = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            Console.WriteLine("Task 1 (max method): " + Max(a1));
            Console.WriteLine("Task 2 (numberOfUniqueInSortedArray method): " + NumberOfUniqueNrInSortedArray(a2));
            Console.WriteLine("Task 3 (numberOfUniqueNrInAnyArray method): " + NumberOfUniqueNrInAnyArray(a3));
            Rotate(a4);
            String s1 = "ABC";
            String s2 = "DEFGH";
            Console.WriteLine(Braiding(s1, s2));
            // ADBECF GH
        }


        // METHOD TO FIND THE BIGGES NUMBER IN AN ARRAY AND PLACE IT AT THE END
        public static int Max(int[] a)
        {
            // Start variable which starts at 0 and an indexChanges variable which starts at -1
            int start = 0;
            int indexChanges = -1;

            // Checking if the array is emtpy, if yes, throw an exception to the user...
            if (a.Length == 0)
            {
                // Throws exception
                throw new Exception("The array is empty!");
            }

            // Loop throigh the array
            for (int i=0;i<a.Length;i++)
            {
                // If the start variable is not the same as the index of the last element in the array, increase with 1.
                if (start != a.Length-1)
                {
                    start++;
                }

                // Here we check if the element the for-loop goes through is bigger or equel to the next element, if yes, then the next elements value is sat to the previous elements value as its bigger.
                if (a[i]>=a[start])
                {
                    // Setting the next elements value, to the current value
                    a[start] = a[i];
                    indexChanges++;
                }
            }
            // Returns the last element, as thats where the bigges number in the array is.
            Console.WriteLine("There was " + indexChanges + " amounts of index changes during the process of finding the largest number in the array!");
            return a[a.Length - 1];
        }



        // METHOD TO FIND THE NUMBER OF UNIQUE NUMBERS IN A SORTED ARRAY
        public static int NumberOfUniqueNrInSortedArray(int[] a)
        {
            // The number of unique number starts at 1, as the array needs to have aleast 1 unique numer or else the method will return 0.
            int numberOfUnique = 1;
            // We need a start point for the sortedArray
            int start = 0;
            // We create a new array and set the values to the same as the array that comes in.
            int[] sortedArray = a.ToArray();
            // Then we sort the new array we just created
            Array.Sort(sortedArray);

            // For loop to go through the arrays.
            for (int i=0;i<a.Length;i++) {
                // If the array that came in as a parameter in the method and the created sorted array is not equal it means its not sorted, then we throw an exception...
                if (a[i]!=sortedArray[i])
                {
                    throw new Exception("The array you inserted is not sorted!");
                }

                // As long as start is not the number of the last index in the array we keep on incrementing the start value
                if (start != a.Length-1)
                {
                    // We increment the value of the start
                    start++;
                }

                // If the number besides the number we check are not equal in a sorted list, it means its a unqiue number
                if (a[i]!=a[start])
                {
                    // We increment the value of the numberOfUnique
                    numberOfUnique++;
                }

            }
            // If the length of the array is 0, it means it has no unique numbers because its empty. We therefore return 0
            if (a.Length == 0)
            {
                return 0;
            }

            // If the array is not empty, we return the numbers of unique numbers that we gathered in the for-loop.
            return numberOfUnique;
        }




        // METHOD TO FIND THE NUMBER OF UNIQUE NUMBERS IN ANY INT ARRAY
        public static int NumberOfUniqueNrInAnyArray(int[] a)
        {
            int nrOfUniqueNr = 0;
            int nrOfNotUnique = 0;
            int start = 0;
            for (int i=0;i<a.Length;i++)
            {
                for (int j=0;j<a.Length;j++)
                {
                    if (start != a.Length - 1)
                    {
                        // We increment the value of the start
                        start++;
                    }
                    if (a[i] == a[start])
                    {
                        nrOfNotUnique++;
                    }
                }
                start = 0;
            }


            // { 3, 2, 1, 3 };
            //Først sjekker vi tallet 3
            // 3 != 2
            // 3 != 1
            // 3 == 3 (1)


            // 2 != 3
            // 2 == 2
            // 2 != 1
            // 2 != 3
            // 1+1-1=1


            Console.WriteLine(nrOfNotUnique);
            return nrOfUniqueNr;
        }




        // METHOD TO PART SORT AN ARRAY 
        public static void PartSort(int[] a)
        {
            int start = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i != a.Length-1)
                {
                    start++;
                }



            }
        }



        public static void Rotate(char[] a)
        {

            // {'A', 'B', 'D', 'E' } må bli til {'E', 'A', 'B', 'D' }
            // Lagre andre posjisjon, som har B, og flytt første posisjon til andre (A->B) {'', 'A', 'D', 'E' }
            // Lagre tredje posisjon i en annen variabel, som har D, og sett den til den første lagrede (D->B) ( {'', 'A', 'B', 'E' }
            // Nå har vi D lagret i den andre variabelen. 
            // {'A', 'B', 'D', 'A' }



            // If the array is of size 0 or 1, we print it out normally.
            if (a.Length == 0 || a.Length == 1)
            {
                Console.WriteLine("[{0}]", string.Join(", ", a));
            } else
            {
                int start = 1;
                char saved;
                char saved2 = 'A';
                saved = a[0];
                a[0] = a[a.Length - 1];

                for (int i = 1; i < a.Length; i++)
                {
                    if (i != a.Length - 1)
                    {
                        start++;
                    }
                    if (i == 1)
                    {
                        saved2 = a[i];
                        a[i] = saved;
                    } else
                    {
                        a[i] = saved2;
                        saved2 = a[i];
                    }


                    // {'A', 'B', 'D' }
                    // {'D', 'B', 'D' } saved=A
                    // {'D', 'A', 'D' } saved2=B
                    
                }
                Console.WriteLine("[{0}]", string.Join(", ", a));
            }
        }


        public static String Braiding(string s, string t)
        {
            string braided = "";
            string rest = "";
            int diff = 0;
            int arraySize = s.Length;

            if(s.Length>t.Length)
            {
                diff = s.Length - t.Length;
                rest = s.Substring(t.Length, diff);
                arraySize = t.Length;
            }

            if (s.Length<t.Length)
            {
                diff = t.Length - s.Length;
                rest = t.Substring(s.Length, diff);
                arraySize = s.Length;
            }

            for (int i = 0; i < arraySize; i++)
            {
                braided = braided + s[i] + t[i];
            }

            return braided + " " + rest;
        }


    }
}