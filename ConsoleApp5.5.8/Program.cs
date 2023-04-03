namespace ConsoleApp5._5._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PowerUp(3, 3));
        }
        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N, (byte)(pow - 1));
                }
            }
        }
    }
}