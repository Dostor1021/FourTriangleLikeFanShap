using System;

class Program
{
    static void Main()
    {
        //upper
        int n = 5;
        int u = 15;
        int q = 20;

        for (int i = 5; i >= 0; i--)
        {

            for (int j = 1; j <= q - i; j++)
            {
                Console.Write(" ");
            }


            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        //middle 
        int T = 5;


        for (int i = 1; i <= T; i++)
        {
            for (int spc = 1; spc < 15; spc++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            for (int k = 1; k <= T - i; k++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= T - i; k++)
            {
                Console.Write(" ");
            }



            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }


        for (int i = T - 1; i >= 1; i--)
        {


            for (int spc = 1; spc < 15; spc++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            for (int k = 1; k <= T - i; k++)
            {
                Console.Write(" ");
            }



            for (int k = 1; k <= T - i; k++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        //bottem

        for (int i = 1; i <= n; i++)
        {

            for (int j = 1; j <= q - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }








    }


}