/*2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
   I ededin 4%-ni tap. 
   Sonra II ededin 9% ni tap. 
   Sonra Cavalari toplayib 10 %ni tap.*/

step1:

Console.WriteLine("type the 1st 4 digit number");
string num1 = Console.ReadLine();
double a =Convert.ToDouble(num1);

if (a > 999 && a < 10000)
{ Console.WriteLine("Number is right"); }
else
{
    Console.WriteLine("number is wrong");
    goto step1;
};

step2:

Console.WriteLine("type the 2nd 7 digit number");
string num2 = Console.ReadLine();
double b = Convert.ToDouble(num2);

if (b > 999999 && b< 10000000)
{ Console.WriteLine("Number is right"); }
else
{
    Console.WriteLine("number is wrong");
    goto step2;
};

double c;
double d;
double e;


    c = a * 0.04; //4 % of num 1
    Console.WriteLine($"4 % of {a}");

    d = b * 0.09;// 9% of num 2
    Console.WriteLine($"9 % of {b}");

    e = (c + d) * 0.1;   // 10% from num 1+num 2
    Console.WriteLine($"10 % of {a}+{b} is {e}");

       
