/*6 dene 6 reqemli eded verilib. Evvel hamisini topla . Sonra I ve III ededi bir birine yapishdir ve bir eded al.  
    I neticeden II neticeni cix. Alinan cavabin 10% tap. Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11% tap.*/


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
double d = Convert.ToDouble(num4);

if (d > 99999 && d < 1000000)
{ Console.WriteLine("Number is right"); }
else
{
    Console.WriteLine("number is wrong");
    goto step4;
};


step5:
Console.WriteLine("type the 5th 6 digit number");
string num5 = Console.ReadLine();
double e = Convert.ToDouble(num5);

if (e > 99999 && e < 1000000)
{ Console.WriteLine("Number is right"); }
else
{
    Console.WriteLine("number is wrong");
    goto step5;
};

step6:
Console.WriteLine("type the 6th 6 digit number");
string num6 = Console.ReadLine();
double f = Convert.ToDouble(num6);

if (f > 99999 && f < 1000000)
{ Console.WriteLine("Number is right"); }
else
{
    Console.WriteLine("number is wrong");
    goto step6;
};





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




g = a + b + c + d + e + f;  // Evvel hamisini topla 

Console.WriteLine($" Evvel hamisini topla  , netice = {g}");

h = a * 1000000 + c;    // Sonra I ve III ededi bir birine yapishdir ve bir eded al.

Console.WriteLine($" ESonra I ve III ededi bir birine yapishdir ve bir eded al. , netice = {h}");

i = g - h; //   I neticeden II neticeni cix.

Console.WriteLine($" I neticeden II neticeni cix.. , netice = {i}");

j = 0.1 * i;  // Alinan cavabin 10% tap.
Console.WriteLine($" Alinan cavabin 10% tap. , netice = {j}");

k = j + e + f;     // Neticenin uzerine V ve VI ededleri gel
Console.WriteLine($" Neticenin uzerine V ve VI ededleri gel , netice = {k}");

l = k * 0.11;           //  Yekunda alinan cavabin 11% tap.*
Console.WriteLine($" Yekunda alinan cavabin 11% tap , netice = {l}");