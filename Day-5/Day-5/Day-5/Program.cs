namespace Day_5
{

    //single cast
    public delegate void MyDelegate(string msg);
    internal class Program
    {
        public static void Show(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            MyDelegate del = Show;
            del("Vikash");
            Console.WriteLine("Hello, World!");
        }
    }
}
