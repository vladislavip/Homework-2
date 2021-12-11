/*4 reqemli eded verilib. Bu ededin evvel 20%-ni , sonra ise cavabin 10% tap.  Alinan  cavabin kvadratini tap. */

STEP1:
Console.Write("4 digit number please:");
string number = Console.ReadLine();
double a = Convert.ToDouble(number);
double b;
double c;
Console.Clear();

if (a < 10000 && a > 999)

{
    b = a * 0.2;  //20 %
    Console.WriteLine($"your 20% from the {a} gives you:{b}");

    c = b * 0.1;  // 10%
    Console.WriteLine($"your 10% from {b} is {c}");

}
else
{      
 Console.WriteLine("TRY AGAIN");

 goto STEP1;

}