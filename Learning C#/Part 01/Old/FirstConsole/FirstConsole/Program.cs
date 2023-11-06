using mpNuget;
using System;
using System.Net.Mail;

namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //RestClient client = new RestClient();
            //client.Send();

            int x = Sum(10, 20);

            Console.WriteLine(x);
            Console.ReadKey();
        }

        static int Sum(int a, int b)
        {
            int s = a + b;

            return s;
        }
    }
}
