// See https://aka.ms/new-console-template for more information


namespace CSharpFundamentals
{
    class Program
    {
        //public static bool Coprime(int a, int b)
        //{
        //    for (int i = 2; i < Math.Min(a, b); i++)
        //    {
        //        if (a % i == 0 && b % i == 0)
        //            return false;
        //    }

        //    return true;
        //}

        public static bool Coprime(int a, int b)
        {
            int min = Math.Min(a, b);
            return Enumerable.Range(2, min - 1).All(factor => !(a % factor == 0 && b % factor == 0));
        }


        static void Main(string[] args)
        {

            Console.WriteLine(Coprime(25, 12));
            Console.WriteLine(Coprime(7, 11));
            Console.WriteLine(Coprime(30, 9));
            Console.WriteLine(Coprime(6, 24));

        }
    }
}


//testing git