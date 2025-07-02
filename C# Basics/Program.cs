namespace C__Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            // Value Type 
            // 1. Passing  by Value [if u change values of the Var in the Function it wont change in the local Var]
            //int a = 5; int b = 6;
            //Console.WriteLine(a);// 5
            //Console.WriteLine(b);// 6
            //Swap(a, b);
            //Console.WriteLine(a);// 5
            //Console.WriteLine(b);// 6

            // 2. Passing  by Ref [if u change values of the Var in the Function it will change in the local Var also]

            //int A = 5; int B = 6;
            //Console.WriteLine(A);// 5
            //Console.WriteLine(B);// 6
            //Swap2(ref A, ref B);
            //Console.WriteLine(A);// 6
            //Console.WriteLine(B);// 5



            #endregion

            #region 2. Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example
            // 1. Passing  by Value [if u change values of the Var in the Function it will change in the local Var also but if u change the ref of the var in function it'll not change in the local Var]
            //int[] arr = { 1, 2, 3 };
            //int result = SumArray(arr);
            //Console.WriteLine(result);// 5
            //Console.WriteLine(arr[0]);// 50
            //// 2. Passing  by Ref [if u change values of the Var in the Function it will change in the local Var also and if u change the ref of the var in function it'll change in the local Var also]
            //// and u can change the reference it self
            //int[] arr2 = { 1, 2, 3 };
            //int result2 = SumArray2(ref arr2);
            //Console.WriteLine(result2);// 5
            //Console.WriteLine(arr2[0]);// 50
            #endregion

            #region 3. Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int x = 7;
            //int y = 5;
            //string op1 = "+", op2 = "-";
            //int rsum, rsub;
            //FourPar(x, y, op1, op2, out rsum, out rsub);
            //Console.WriteLine(rsum);
            //Console.WriteLine(rsub);
            #endregion

            #region 4. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.Write("Enter a Number: ");
            //int.TryParse(Console.ReadLine(), out int Numbb);
            //Console.Clear();

            //Console.WriteLine(CalcIndivdual(Numbb));
            #endregion

            #region 5. Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.Write("Enter a Number: ");
            //int.TryParse(Console.ReadLine(), out int Numbb);
            //Console.Clear();

            //Console.WriteLine(IsPrime(Numbb));
            #endregion

            #region 6. Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] MMarr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //int MaxArr, MinArr = 0;
            //MinMaxArray(MMarr, out MaxArr, out MinArr);
            //Console.WriteLine($"Max Value : {MaxArr}");
            //Console.WriteLine($"Min Value : {MinArr}");
            #endregion

            #region 7. Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            Console.Write("Enter a Number: ");
            int.TryParse(Console.ReadLine(), out int Numbb);
            Console.Clear();
            int Result = 0;
            calFactorial(Numbb, out Result);
            Console.WriteLine(Result);
            #endregion


        }
        public static void Swap(int x, int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }
        public static void Swap2(ref int x, ref int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }

        public static int SumArray(int[] Arr)
        {
            int sum = 0;
            Arr[0] = 50;
            for (int i = 1; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }
            return sum;
        }
        public static int SumArray2(ref int[] Arr)
        {
            int sum = 0;
            Arr[0] = 50;
            for (int i = 1; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }
            return sum;
        }

        public static void FourPar(int num1, int num2, string op1, string op2, out int sum, out int sub)
        {
            sum = sub = 0;
            if (op1 == "+")
                sum = num1 + num2;

            if (op2 == "-")
                sub = num1 - num2;
        }

        public static int CalcIndivdual(int num1)
        {
            int sum = 0;

            while (num1 > 0)
            {
                int digit = num1 % 10;
                sum += digit;
                num1 /= 10;
            }

            return sum;
        }

        public static bool IsPrime(int num1)
        {
            bool IsPrim = true;
            if (num1 <= 2)
                return IsPrim = false;
            for (int i = 2; i <= num1 / 2; i++)
            {
                if (num1 % i == 0)
                {
                    IsPrim = false;
                    break;
                }
            }
            return IsPrim;


        }

        public static void MinMaxArray(int[] Numbers, out int max, out int min)
        {
            max = Numbers.Max();
            min = Numbers.Min();
        }

        public static void calFactorial(int Number, out int result)
        {
            result = 1;
            for (int i = 1; i <= Number; i++)
            {
                result *= i;
            }
        }

    }
}
