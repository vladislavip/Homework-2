/*4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap.*/
STEP1:
Console.Write("4 digit number please:");
string number = Console.ReadLine();
double a = Convert.ToDouble(number);
double b;
double c;
Console.Clear();

if (a<10000 && a>999)

{
    b = a * 100 + 44; //+44 at the ending
    Console.WriteLine($"your +44 at the ending gives you:{b}");

    c = b * 0.44; // 44%
    Console.WriteLine($"your 44% from {b} is {c}");
    
} else
{
    Console.WriteLine("TRY AGAIN");

    
    goto STEP1;



}