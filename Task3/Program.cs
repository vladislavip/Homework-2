/*5 reqemli eded verilib. Bu ededin evvel  18 % sonra ise 3 % tap.*/
Step1:
Console.WriteLine("hi , 5 digit number please");
string number = Console.ReadLine();
int a= Convert.ToInt32(number);
double b;
double c;

if (a < 100000 && a > 9999)
{
    b = a * 0.18;  //18%
  
   Console.WriteLine($"18 % ofYOUR NUMBER IS:{b}");

    c = b * 0.03;

    Console.WriteLine($"3 % ofYOUR 18 % is:{c}");
}
else { Console.WriteLine("TRY AGAIN");
    goto Step1;
}