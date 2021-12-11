/*3 dene 4 reqemli eded verilib.  I ededin 1%-ni, II ededin 2% , III ededin 3 % tap. 
    Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7% faizini gel */


step1:

Console.WriteLine("type the 1st 4 digit number");
string num1 = Console.ReadLine();
double a = Convert.ToDouble(num1);

if (a > 999 && a < 10000)
{ Console.WriteLine("Number is right"); }
else
{
    Console.WriteLine("number is wrong");
    goto step1;
};


step2:
Console.WriteLine("type the 2nd 6 digit number");
string num2 = Console.ReadLine();
double b = Convert.ToDouble(num2);

if (b > 999 && b < 10000)
{ Console.WriteLine("Number is right"); }
else
{
    Console.WriteLine("number is wrong");
    goto step2;
};

step3:
Console.WriteLine("type the 3rd 6 digit number");
string num3 = Console.ReadLine();
double c = Convert.ToDouble(num3);

if (c > 999 && c < 10000)
{ Console.WriteLine("Number is right"); }
else
{
    Console.WriteLine("number is wrong");
    goto step3;
};


double d;
double e;
double f;
double g;
double h;

d = a * 0.01;  //1% of num1
Console.WriteLine($" 10% of {a} is {d}");
e = a * 0.02;  //2% of num2
Console.WriteLine($" 10% of  {b} is {e}");
f = a * 0.03;   //3% of num3
Console.WriteLine($" 10% of {c} is {f}");
g = d - e - f;  // substraction a-b-c
Console.WriteLine($" substraction of {d} {e} {f} is equal to {g}");

h = c * 0.07 + g; // 7% of number c (3rd) +subsraction a-b-c

Console.WriteLine($"7% of number {c} plus result of substruction of {d} {e} {f}");






