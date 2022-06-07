using System;
using System.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LoopsWithArray();
            //GreetFriendForeachLoop();
            //FirstArrayChallenge();
            //MultiDimensionalArrays();
            //NestedForLoopsAnd2DArrays();
            //NestedForLoopsDiagonalRightToLeft();
            //JaggedArrays();
            //JaggedArraysChallenge();
            //Console.WriteLine(GetAverage(intArray));
            var intArray = new int[] { 1, 2, 3, 4, 5 };
            var happiness = new int[] { 10, 20, 30, 40, 5 };
            HappinessMethod(happiness);
            foreach(var happyPap in happiness)
            {
                Console.WriteLine(happyPap);
            }

        }

        public static void DeclareAndIntializeArray()
        {
            //declare and initialize an array
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 18;
            grades[4] = 10;

            Console.WriteLine(grades[0]);

            Console.WriteLine("give a new grade value");
            //assigning new value to array at index 0
            grades[0] = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"new grade at index 0: {grades[0]}");

            //another way of initializing array
            int[] classGrades = { 20, 15, 20, 10, 15 };

            //another way of initializing array
            int[] anotherClassGrades = new int[] { 20, 15, 20, 10, 15 };
            Console.WriteLine(anotherClassGrades.Length);
        }

        public static void LoopsWithArray()
        {
            //iterate with for loop
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine($"Index{j}: {nums[j]}");
            }

            //foreach loop
            int indexCounter = 0;
            foreach (int number in nums)
            {
                Console.WriteLine($"{indexCounter++} : {number}");
            }
        }
        public static void GreetFriendForeachLoop()
        {
            string[] friends = { "tim", "tod", "sam", "bill", "kev" };

            foreach (var friend in friends)
            {
                Console.WriteLine($"Hello {friend}");
            }
        }
        public static void FirstArrayChallenge()
        {
            Console.WriteLine("type anything here");
            string input = Console.ReadLine();
            Console.WriteLine("What kind of data type did you enter: \n" +
                "type 1 for string\n" +
                "type 2 for int\n" +
                "type 3 for bool\n");
            int numInput = int.Parse(Console.ReadLine());

            switch (numInput)
            {
                case 1:
                    //helper method to check for valid string with no ints, could also use .Any(char.isDigit) if using linq
                    bool isAlphabetic = IsAlphabeticCheck(input);
                    if (isAlphabetic)
                    {
                        Console.WriteLine("Invalid string: " + input);
                    }
                    else
                        Console.WriteLine($"Valid string: {input}");
                    break;

                case 2:
                    bool value = int.TryParse(input, out int validInt);
                    if (value)
                    {
                        Console.WriteLine($"Valid int: {validInt}");
                    }
                    else
                        Console.WriteLine($"Invalid int {input}");
                    break;
                case 3:
                    bool boolVal = bool.TryParse(input, out bool result);
                    if (boolVal)
                    {
                        Console.WriteLine($"Valid bool {result}");
                    }
                    else
                        Console.WriteLine($"Invalid bool: {input}");
                    break;
                default:
                    Console.WriteLine("Something went very, very wrong, goodbye");
                    break;
            }
        }

        private static bool IsAlphabeticCheck(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                    return false;
            }
            return true;
        }

        //multidimensional array
        public static void MultiDimensionalArrays()
        {
            //2D array
            string[,] matrix;

            //values are found by using row first then column
            // indices 0,2 would be the value of 3
            // array2D[2,1] = 8
            int[,] array2D = new int[,]
            {
                {1,2,3 }, // row 0
                {4,5,6 }, // row 1
                {7,8,9 }, // row 2
            };

            Console.WriteLine($"Central value is : {array2D[1, 1]}");
            Console.WriteLine($"Number at matrix index value row 2,column 0: {array2D[2, 0]}");
            // 3D array 
            int[,,] threeD;


            //same as 2D, just extra dimension, the depth
            //values of 0,0,0 would be 1
            //array3D[1,1,1] = 11;
            int[,,] array3D = new int[,,]
            {
                {
                    {1,2,3},
                    {4,5,6},
                },
                {
                    {7,8,9},
                    {10,11,12}
                }
            };
            Console.WriteLine(array3D[0, 1, 0]); // = 4

            //another way to declare multi-d array
            string[,] newArray2D = new string[3, 2]
            {
                {"one", "two" },
                {"three", "four"},
                {"five","six"}
            };
            Console.WriteLine(newArray2D[1, 1]);
            newArray2D[1, 1] = "chicken";
            Console.WriteLine(newArray2D[1, 1]);

            //gets numbers of dimensions of array when you have array name but not sure of the layout
            int dimensions = newArray2D.Rank;
            Console.WriteLine(dimensions);
        }

        public static void NestedForLoopsAnd2DArrays()
        {
            int[,] matrix =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            //foreach(int item in matrix)
            //{
            //    Console.Write(item + " ");
            //}

            //outer for loop to go through the rows GetLength(0) is getting the length of the first dimension (0) or the rows
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                //inner loop to iterate through the columns
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //printing diagonal from left to right, when i == j, print the number
                    if (i == j)
                        Console.Write(matrix[i, j] + " ");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }

        }
        public static void NestedForLoopsDiagonalRightToLeft()
        {
            int[,] matrix =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            //using counter variables only works when # of columns matches # of rows
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.Write(matrix[i, j]);
            }
        }
        public static bool Checker(string[,] board)
        {
            // TODO
            for (int i = 0; i < board.GetLength(0); i++)
            {
                //horizontal
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return true;
                //vertical
                if (board[0, i] == board[1, i] && board[0, i] == board[2, i])
                    return true;
            }
            //diagonal checks
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return true;
            if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
                return true;
            return false;
        }

        public static void JaggedArrays()
        {
            //declaration
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];
            jaggedArray[0] = new int[] { 0, 1, 2, 3, 4 };
            jaggedArray[1] = new int[] { 0, 1, 2, 3 };
            int[][] jaggedArrayTwo = new int[][]
            {
                new int[]{0,2,3},
                new int[]{1,2,3}
            };
            Console.WriteLine($"The value in the middle of first entry is {jaggedArrayTwo[0][1]}");
            Console.WriteLine(jaggedArray[0][3]);
            foreach (int[] array in jaggedArrayTwo)
            {
                foreach(int number in array)
                {
                    Console.Write(number + " ");
                }
            }
        }
        public static void JaggedArraysChallenge()
        {
            string[][] friendsarray = new string[3][]
            {
                new string[]{"Tim", "Ted" },
                new string[]{"Shelly", "Bill" },
                new string[]{"Dave", "Stacy" }
            };

            Console.WriteLine($"Hi {friendsarray[0][0]}, my name is {friendsarray[1][0]}, do you know {friendsarray[2][1]}?");
        }

        public static double GetAverage(int[] gradesArray)
        {
            double average;
            int sum = 0;
            for(int i = 0; i < gradesArray.Length; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / gradesArray.Length;
            return average;
        }

        public static void HappinessMethod(int[] happiness)
        {
            for(int i = 0; i < happiness.Length; i++)
            {
                happiness[i] += 2;
            }
        }
    }
}
