using System;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /*7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
    3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
    Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
    Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
    Sonra alinan cavabin ustune gel 6 reqemli ededi.
    Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
    Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
    Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.*/


        step1:
            Console.WriteLine("type the 1st 3 digit number");
            string num1 = Console.ReadLine();
            double a = Convert.ToDouble(num1);

            if (a > 99 && a < 1000)
            { Console.WriteLine("Number is right"); }
            else
            {
                Console.WriteLine("number is wrong");
                goto step1;
            };


        step2:
            Console.WriteLine("type the 2nd 3 digit number");
            string num2 = Console.ReadLine();
            double b = Convert.ToDouble(num2);

            if (b > 99 && b < 1000)
            { Console.WriteLine("Number is right"); }
            else
            {
                Console.WriteLine("number is wrong");
                goto step2;
            };

        step3:
            Console.WriteLine("type the 3rd 4 digit number");
            string num3 = Console.ReadLine();
            double c = Convert.ToDouble(num3);

            if (c > 999 && c < 10000)
            { Console.WriteLine("Number is right"); }
            else
            {
                Console.WriteLine("number is wrong");
                goto step3;
            };


        step4:
            Console.WriteLine("type the 4rd 4 digit number");
            string num4 = Console.ReadLine();
            double d = Convert.ToDouble(num4);

            if (d > 999 && d < 10000)
            { Console.WriteLine("Number is right"); }
            else
            {
                Console.WriteLine("number is wrong");
                goto step4;
            };


        step5:
            Console.WriteLine("type the 5th 5 digit number");
            string num5 = Console.ReadLine();
            double e = Convert.ToDouble(num5);

            if (e > 9999 && e < 100000)
            { Console.WriteLine("Number is right"); }
            else
            {
                Console.WriteLine("number is wrong");
                goto step5;
            };

        step6:
            Console.WriteLine("type the 6th 5 digit number");
            string num6 = Console.ReadLine();
            double f = Convert.ToDouble(num6);

            if (f > 9999 && f < 100000)
            { Console.WriteLine("Number is right"); }
            else
            {
                Console.WriteLine("number is wrong");
                goto step6;
            };


        step7:
            Console.WriteLine("type the 7th 6 digit number");
            string num7 = Console.ReadLine();
            double g = Convert.ToDouble(num7);

            if (g > 99999 && g < 1000000)
            { Console.WriteLine("Number is right"); }
            else
            {
                Console.WriteLine("number is wrong");
                goto step7;
            };



            double h;
            double i;
            double j;
            double k;
            double l;
            double m;
            double n;
            double o;
            double p;
            double q;



            h = a + b;              //3 reqemli ededleri topla
            Console.WriteLine($"3 reqemli ededleri topla, netice ={h}");
            i = h + c * d;         // sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
            Console.WriteLine($"onra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi, netice ={i}");
            j = i * 10 + 7;       // Sonra neticenin axirina 7 reqemini artir.
            Console.WriteLine($"Sonra neticenin axirina 7 reqemini artir., netice ={g}");
            k = j + e + f;              // Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
            Console.WriteLine($"onra cavabin ustune gel 5 reqemli ededlerin cemini, netice ={k}");
            l = k - (a * b * 10 + 1);   //Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
            Console.WriteLine($"Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini, netice ={l}");
            m = l + g;                   //Sonra alinan cavabin ustune gel 6 reqemli ededi.
            Console.WriteLine($"Sonra alinan cavabin ustune gel 6 reqemli ededi, netice ={m}");
            n = m - (a + b + c + d);     //Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
            Console.WriteLine($"onra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini, netice ={n}");
            o = n * 0.18 * 0.03 * 0.01;  //Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
            Console.WriteLine($"Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap, netice ={o}");
            p = o + (e + f);             // Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel
            Console.WriteLine($"Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel, netice ={p}");

        }
    }
}
