/*3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.*/
step1:

Console.WriteLine("type the 1st 6 digit number");
string num1 = Console.ReadLine();
double a = Convert.ToDouble(num1);

if (a > 99999 && a < 1000000)
{ Console.WriteLine("Number is right"); }
else {
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


double d;
double e;
double f;   
double g;

d = a * 0.01;  //10% of num1
Console.WriteLine($" 10% of {a}");
e = a * 0.01;  //10% of num1
Console.WriteLine($" 10% of  {b}");
f = a * 0.01;   //10% of num1
Console.WriteLine($" 10% of {c}");

g = (d + e + f)*0.1; // 10 % of sum of 10%
Console.WriteLine("10 % of sum fo all 10%'s ");


