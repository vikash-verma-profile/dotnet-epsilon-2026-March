namespace Day_1
{
    internal class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            Console.WriteLine("Inside Swap Method");
            //a=a+b;
            //b=a-b;
            //a =a-b;
            int c = a;
            a = b;
            b=c;
            Console.WriteLine($"a={a},b={b}");
        }

        public static void sample(int a,int b,int c=8)
        {
            Console.WriteLine(a+b+c);
        }

        public static void SumSample(params int[] values)
        {
            foreach (int v in values) Console.WriteLine(v);
        }
        public static int Sum(ref int a, ref int b)
        {
            return a + b; 
        }
        public static void Sum(int a, int b, out int c)
        {
           c=a + b;
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int Number1=1,Number2=2;
            Console.WriteLine($"a={Number1},b={Number2}");
            Swap(ref Number1, ref Number2);
            Console.WriteLine($"a={Number1},b={Number2}");
            int output;
            int a=1, b=3;
            Sum(ref a, ref b);
            Sum(Number1,Number2,out output);
            Console.WriteLine(output);
           // sample(1, 2);
            sample(b:1, a:2);
            SumSample(1, 2, 3, 4,5,6,7,8);

        }
    }
}
