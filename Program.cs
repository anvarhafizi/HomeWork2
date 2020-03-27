using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercise 1
            double a=16.80, b=12.40;
            Console.WriteLine("exercise 1="+Math.Sqrt(a*b));
            //exercise 2
            double A=1.40, B=-5.50, C=0.60, AC,BC;
                AC=Math.Abs(A-C);
                BC=Math.Abs(B-C);
                Console.WriteLine("exercise 2="+"AC="+AC+" "+"BC="+BC);
                Console.WriteLine(AC+BC);
            //exercise 3
            double x1=-6.20, y1=5.20, x2=2.10, y2=9.80, xy1,xy2;
                //xy1=Math.Abs(x1-y1);
                //xy2=Math.Abs(x2-y2);
                Console.WriteLine("exercise 3="+Math.Sqrt(Math.Pow(x2-x1,2)+(Math.Pow(y2-y1,2))));
            //exercise 4
            int n=41,x,z;
                x=n/10;
                z=n%10;
            Console.WriteLine("exercise 4="+z+x);
            //exercise 5
            int N=10985/60;
                Console.WriteLine("exercise 5="+N);
            //exercise 6
            int K=202%7;
            Console.WriteLine("exercise 6="+K);
            Console.ReadKey();

        }
    }
}
