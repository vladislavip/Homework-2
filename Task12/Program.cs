/* 4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla. 
    Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap.*/

step1:
Console.WriteLine("type the 1st 6 digit number");
string num1 = Console.ReadLine();
double a = Convert.ToDouble(num1);

if (a > 99999 && a < 1000000)
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

if (b > 99999 && b < 1000000)
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

if (c > 99999 && c < 1000000)
{ Console.WriteLine("Number is right"); }
else
{
    Console.WriteLine("number is wrong");
    goto step3;
};


step4:
Console.WriteLine("type the 4rd 6 digit number");
string num4 = Console.ReadLine();
double d = Convert.ToDouble(num3);

if (d > 99999 && d < 1000000)
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
double l;   
double m;
double n;
double o;
double p;   
double q;

e = a *0.01;  //10 % of num1 
Console.WriteLine($"10 % of num1 is {e}");
f = b * 0.01;  //10 % of num2
Console.WriteLine($"10 % of num2 is {f}");
g = c * 0.01;   //10 % of num3
Console.WriteLine($"10 % of num3 is {g}");
h = d * 0.01;  //10 % of num4
Console.WriteLine($"10 % of num4 is {h}");
i = e+f+g+h;   //10 % of num1+num2+num3+num4
Console.WriteLine($" 10% of num1+num2+num3+num4 is {i}");
j = a * 0.15; //15 % of num1 
Console.WriteLine($"15 % of num1 is {j}");
k = b * 0.15; //15 % of num2 
Console.WriteLine($"15 % of num1 is {k}");
l = c * 0.15; //15 % of num3 
Console.WriteLine($"15 % of num1 is {l}");
m = d* 0.15; //15 % of num4 
Console.WriteLine($"15 % of num1 is {m}");
n = j + k + l + m; //15% of num1+num2+num3+num4
Console.WriteLine($" 15% of num1+num2+num3+num4 is {n}");
o = i * n; // multiplication of 10% of sum to 15% of sum 
Console.WriteLine($" the result from multiplication of 10% of sum to 15% of sum is {o}");
p = o * 0.1; // 10% of multiplication of 10% of sum to 15% of sum 
Console.WriteLine($"10% of multiplication of 10% of sum to 15% of sum  is {p}");
q = p * 0.11; //11% from 10% of multiplication of 10% of sum to 15% of sum 
Console.WriteLine($"11% from 10% of multiplication of 10% of sum to 15% of sum is {q}");