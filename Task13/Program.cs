/*5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5% tap , neticeleri vur bir birine. 
    Sonra 3 reqemli ededlerin 3% tap , neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla.*/

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
Console.WriteLine("type the 4rd 3 digit number");
string num4 = Console.ReadLine();
double d = Convert.ToDouble(num4);

if (d > 99 && d < 1000)
{ Console.WriteLine("Number is right"); }
else
{
    Console.WriteLine("number is wrong");
    goto step4;
};


step5:
Console.WriteLine("type the 4rd 3 digit number");
string num5 = Console.ReadLine();
double e = Convert.ToDouble(num5);

if (e > 99 && e < 1000)
{ Console.WriteLine("Number is right"); }
else
{
    Console.WriteLine("number is wrong");
    goto step5;
};



double f;
double g;
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



f = a * 0.05;  //5 % of num1
Console.WriteLine($"5 % of num1 is {f}");
g = b * 0.05;  //5 % of num2
Console.WriteLine($"5 % of num2 is {g}");
h = c * 0.05;   //5 % of num3
Console.WriteLine($"5 % of num3 is {h}");
i = d * 0.05;  //5 % of num4
Console.WriteLine($"5 % of num4 is {i}");
j = e * 0.05;//5 % of num4
Console.WriteLine($"5 % of num5 is {j}");
k = f * g * h * i*j;   //5% of num1*num2*num3*num4*num5
Console.WriteLine($" 5% of num1*num2*num3*num4 is {k}");
l = d * 0.03; // 3% of num 4
Console.WriteLine($"5 % of num4 is {l}");
m = 3 * 0.03;//  3% of num 5
Console.WriteLine($"5 % of num5 is {m}");
n = l + m; //  sum of 3% of num 4 and num 5
Console.WriteLine($"sum of 3% of num 4 and num 5  is {n}");
o = 0.1 * n + 0.1 * k; // 10 % of sum of  two answers
Console.WriteLine($"s10 % of sum of  two answers  is {o}");


