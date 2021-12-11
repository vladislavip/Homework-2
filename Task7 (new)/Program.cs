/*2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap*/
step1:
Console.WriteLine("enter two 5 digit numbers");
Console.WriteLine("Enter the num 1");
string num1= Console.ReadLine();

Console.WriteLine("Enter the num 2");
string num2= Console.ReadLine();


double a= Convert.ToDouble(num1);   
double b= Convert.ToDouble(num2);
double c;

if (a>9999 && a<100000 && b>9999 && b<100000)
    {
    c = (a + b) * 10 + 5;
    Console.WriteLine($"num {a}+{b} and adding 5 at the end gives you {c}");

} else 
{ Console.WriteLine("wrong numbers"); 
goto step1;
}
   