namespace LeetCode
{
    internal class Pow_x_n
    {
        public static void Main(string[] args)
        {
            double x = 2.0000;
            int n = -2147483648;
            //if (n > 0)
            //{
            //    Console.WriteLine(MyPowPositive(x, n));
            //}
            //else
            //{
            //    Console.WriteLine(MyPowNegative(x, n));
            //}
            
            Console.WriteLine(myPow(x,n));

            Console.ReadLine();
        }
        //public static double MyPowPositive(double x, int n)
        //{
        //    if (n == 1)
        //    {
        //        return x;
        //    }
        //    return (double)(x * MyPowPositive(x, n - 1));
        //}

        //public static double MyPowNegative(double x, int n)
        //{
        //    if (n == -1)
        //    {
        //        return x;
        //    }
        //    return (double)(1 / (x * MyPowNegative(x, n + 1)));
        //}

        public static double myPow(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n < 0)
            {
                n = -n;
                x = 1 / x;
            }
            if (n % 2 == 0)
            {
                return myPow(x * x, n / 2);
            }
            else
            {
                return x * myPow(x, n - 1);
            }
        }
    }
}
