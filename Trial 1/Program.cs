using System;

namespace Trial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            float j = 5;
            String color = "red";

            //type casting convert int to string
            Console.WriteLine(i.GetType());

            Console.WriteLine(Convert.ToString(i));
            Console.WriteLine(Convert.ToString(i).GetType());

            Console.WriteLine("\n");

            //converting float to int
            Console.WriteLine(j.GetType());

            Console.WriteLine(Convert.ToInt32(j));
            Console.WriteLine(Convert.ToInt32(j).GetType());



        }
    }
}
