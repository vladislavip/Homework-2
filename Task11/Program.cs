/* 4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel . II ededin usutune IV eeddi gel. 
    Sonra cavablari vur birbirine. Alinan neticeden III ededin 3%-ni cix.*/

step1:

Console.WriteLine("type the 1st 5 digit number");
string num1 = Console.ReadLine();
double a = Convert.ToDouble(num1);

if (a > 9999 && a < 100000)
{ Console.WriteLine("Number is right"); }
else
{
    Console.WriteLine("number is wrong");
    goto step1;
};


step2:
Console.WriteLine("type the 2nd 5 digit number");
string num2 = Console.ReadLine();
double b = Convert.ToDouble(num2);

if (b > 9999 && b < 100000)
{ Console.WriteLine("Number is right"); }
else
{
    Console.WriteLine("number is wrong");
    goto step2;
};

step3:
Console.WriteLine("type the 3rd 5 digit number");
string num3 = Console.ReadLine();
double c = Convert.ToDouble(num3);

if (c > 9999 && c < 100000)
{ Console.WriteLine("Number is right"); }
else
{
    Console.WriteLine("number is wrong");
    goto step3;
};


step4:
Console.WriteLine("type the 4rd 5 digit number");
string num4 = Console.ReadLine();
double d = Convert.ToDouble(num3);

if (d > 9999 && d < 100000)
{ Console.WriteLine("Number is right"); }
else
{
    Console.WriteLine("number is wrong");
    goto step4;
};


double e;
double f;
double g;
double h;
double i;
double j;
double k;

e = a +c;  //1 st + 3rd number 
Console.WriteLine($"1 st + 3rd number  is {e}");
f = b +c;   //2 nd + 3rd number 
Console.WriteLine($"2 nd + 3rd number {f}");
g = c + c;   //3 rd + 3rd number
Console.WriteLine($"3 rd + 3rd number  is {g}");
h = d + c;   //4 th + 3rd number
Console.WriteLine($"4 th + 3rd number  is {e}");
i = b + d;   //2 nd + 4r number
Console.WriteLine($" 2nd + 4r number  is {i}");
j = e * f * g * h * i; // multiplicatrion
Console.WriteLine($" multiplication of all previous results is {j}");
k = j + 0.03 * c; // multiplicatio plus 3% of 3rd number
Console.WriteLine($"multiplication {j} plus 3% of number 3 (C) is {k}");    



