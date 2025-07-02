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
    }
}
