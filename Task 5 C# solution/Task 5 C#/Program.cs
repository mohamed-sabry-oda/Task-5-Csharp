using System;
using System.Linq;

namespace Task_5_C_
{
    internal class Program
    {

        #region problem 9
        //public static void SumAndMultiply(int NumOne, int NumTwo, out int Sum, out int Multiply)
        //{
        //    Sum = NumOne + NumTwo;
        //    Multiply = NumOne * NumTwo;
        //}
        #endregion

        #region problem 10
        //static void PrintString(string text, int times = 5)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        Console.WriteLine(text);
        //    }
        //}
        #endregion



        #region problem 13
        //static int SumArray(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (int num in numbers)
        //    {
        //        sum += num;
        //    }
        //    return sum;
        //}

        #endregion


        #region part02 problem 1
        //public static void print()
        //{
        //    Console.WriteLine("enter a positive num");
        //    int num =int.Parse(Console.ReadLine());
        //    for (int i = 1; i <= num; i++)
        //    {
        //        Console.Write(i + " ");
        //    }
        //}
        #endregion


        #region part02 problem 2
        //public static void print()
        //{
        //    Console.WriteLine("enter an integer num : ");
        //    int num = int.Parse(Console.ReadLine());
        //    for (int i = 1; i <= 12; i++)
        //    {
        //        Console.Write(num * i + " ");
        //    }
        //}
        #endregion


        #region part02 problem 3
        //public static void PrintEven()
        //{
        //    Console.WriteLine("enter num : ");
        //    int num = int.Parse(Console.ReadLine());
        //    for (int i = 1; i <= num; i++)
        //    {
        //        if(i % 2 == 0)
        //        {
        //            Console.Write(i + " ");
        //        }
        //    }
        //}
        #endregion


        #region part02 problem 4
        //public static void exponentiation()
        //{
        //    Console.WriteLine("enter first num: ");
        //    int NumOne = int.Parse(Console.ReadLine());
        //    Console.WriteLine("enter second num : ");
        //    int NumTwo = int.Parse(Console.ReadLine());
        //    int Mul=1;
        //    for(int i = 0; i < NumTwo; i++)
        //    {
        //        Mul *= NumOne;
        //    }
        //    Console.WriteLine("The result is " + Mul);
        //}
        #endregion


        #region part02 problem 5
        //public static void ReverseString() {
        //    Console.WriteLine("enter a string");
        //    string StringOne = Console.ReadLine();
        //    for (int i = StringOne.Length-1; i >= 0; i--)
        //    {
        //        Console.Write(StringOne[i] + " ");
        //    }
        //}
        #endregion


        #region part02 problem 6
        //public static void ReverseInt()
        //{
        //    Console.WriteLine("enter num");
        //    int num = int.Parse(Console.ReadLine());
        //    for (int i = ((num.ToString()).Length) - 1; i >= 0; i--)
        //    {
        //        Console.WriteLine((num.ToString())[i]);
        //    }
        //}
        #endregion



        #region part02 problem 8
        //static string ReverseWords(string sentence)
        //{
        //    return string.Join(" ", sentence.Split(' ').Reverse());
        //}
        #endregion



        static void Main(string[] args)
        {
            #region problem 1
            //try
            //{
            //    Console.WriteLine("enter first num : ");
            //    int x = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter second num : ");
            //    int y = int.Parse(Console.ReadLine());
            //    int z = x / y;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //}
            #endregion


            #region problem 2
            //TestDefensiveCode();
            #endregion

            #region problem 3
            //int? x= null;
            //int y = x ?? default;
            //Console.WriteLine(y);
            //// difference between HasValue and value
            //if (x.HasValue)
            //{
            //    int z = x.Value;
            //    Console.WriteLine(z);
            //}

            #endregion


            #region problem 4
            //try
            //{
            //    int[] ArrOne = { 1, 2, 3, 4, 5 };
            //    ArrOne[6] = 7;
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion



            #region problem 5
            //int[,] ArrOne = new int[3, 3];
            //int sum = 0;
            //for (int i = 0; i < ArrOne.GetLength(0); i++)
            //{

            //    for (int j = 0; j < ArrOne.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"enter element{j + 1}");
            //        ArrOne[i, j] = int.Parse(Console.ReadLine());
            //        sum += ArrOne[i, j];
            //    }
            //}
            //Console.WriteLine("the sum is : " + sum);
            #endregion


            #region problem 6
            //// Step 1: Create a jagged array with different lengths
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[3]; // Row 1 has 3 elements
            //jaggedArray[1] = new int[2]; // Row 2 has 2 elements
            //jaggedArray[2] = new int[4]; // Row 3 has 4 elements

            //// Step 2: Populate with user input
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.WriteLine($"Enter {jaggedArray[i].Length} numbers for row {i + 1}:");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"Element [{i}][{j}]: ");
            //        jaggedArray[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Step 3: Print all values row by row
            //Console.WriteLine("\nJagged Array Contents:");
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.Write($"Row {i + 1}: ");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region problem 7
            //string? StringOne = null;

            //Console.WriteLine("enter string");
            //StringOne = Console.ReadLine();

            //StringOne = null!; //null forgiveness operator
            #endregion



            #region problem 8
            ////Boxing
            //object O1 = new object(); 
            //O1 = "mohamed";

            ////UnBoxing
            //int Y = (int)O1; // Cast from object(ref) to int(value)
            #endregion



            #region problem 9
            //Console.WriteLine("enter first num : ");
            //int N1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter second num : ");
            //int N2 = int.Parse(Console.ReadLine());
            //int SumResult;
            //int MultiplyResult;
            //SumAndMultiply(N1, N2 , out SumResult, out MultiplyResult);

            //Console.WriteLine("the sum is : " + SumResult);
            //Console.WriteLine("the multiply is : " + MultiplyResult);
            #endregion



            #region problem 10
            //PrintString("mohamed", 3);
            //PrintString("sabry");
            #endregion



            #region problem 11
            //int[]? numbers = null;

            //// Safely access the Length property using null propagation
            //Console.WriteLine($"Array length: {numbers?.Length}");
            #endregion



            #region problem 12
            //Console.WriteLine("enter a day ");
            //string Day = Console.ReadLine();

            //switch (Day)
            //{
            //    case "Monday":
            //        Console.WriteLine(1);
            //        break;
            //    case "Tuesday":
            //        Console.WriteLine(2);
            //        break;
            //    case "Wednesday":
            //        Console.WriteLine(3);
            //        break;
            //    case "Thursday":
            //        Console.WriteLine(4);
            //        break;
            //    case "Friday":
            //        Console.WriteLine(5);
            //        break;
            //    case "Saturday":
            //        Console.WriteLine(6);
            //        break;
            //    case "Sunday":
            //        Console.WriteLine(7);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day entered.");
            //        break;
            //}

            #endregion


            #region problem 13
            //// Call with individual values
            //int result1 = SumArray(1, 2, 3, 4, 5);
            //Console.WriteLine($"Sum of individual values: {result1}");

            //// Call with an existing array
            //int[] arr = { 10, 20, 30 };
            //int result2 = SumArray(arr);
            //Console.WriteLine($"Sum of array values: {result2}");
            #endregion



            #region part02 problem 1
            //print();
            #endregion


            #region part02 problem 2
            //print();
            #endregion


            #region part02 problem 3
            //PrintEven();
            #endregion


            #region part02 problem 4
            //exponentiation();
            #endregion


            #region part02 problem 5
            //ReverseString();
            #endregion


            #region part02 problem 6
            //ReverseInt();
            #endregion


            #region part02 problem 7
            //Console.Write("Enter the number of elements: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //// Take input
            //Console.WriteLine("Enter the elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = -1;
            //int element = 0;

            //// Find longest distance between identical elements
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = n - 1; j > i; j--)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1; // cells in between
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //                element = arr[i];
            //            }
            //            break; // No need to check smaller j for same i
            //        }
            //    }
            //}

            //if (maxDistance >= 0)
            //{
            //    Console.WriteLine($"Element: {element}");
            //    Console.WriteLine($"Longest distance: {maxDistance} cells");
            //}
            //else
            //{
            //    Console.WriteLine("No matching elements found.");
            //}
            #endregion


            #region part02 problem 8
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //Console.WriteLine(ReverseWords(sentence));
            #endregion
        }
        #region problem 2
        //public static void TestDefensiveCode()
        //{
        //    int x, y;
        //    bool flag;
        //    do
        //    {
        //        Console.WriteLine("enter value for x");
        //        flag = int.TryParse(Console.ReadLine(), out x);
        //    }while (!flag || x < 0  );
        //    do
        //    {
        //        Console.WriteLine("enter value for y");
        //        flag = int.TryParse(Console.ReadLine(), out y);
        //    } while (!flag || y <= 1);
        //}
        #endregion
    }
}
