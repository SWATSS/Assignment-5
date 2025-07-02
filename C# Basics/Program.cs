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
            int x = 7;
            int y = 5;
            string op1="+", op2="-";
            int rsum, rsub ;
            FourPar(x, y, op1, op2, out rsum, out rsub);
            Console.WriteLine(rsum);
            Console.WriteLine(rsub);
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



    }
}
