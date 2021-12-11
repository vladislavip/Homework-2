
/*2) 3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir. example: 333 = 333333;*/
Step1:

Console.WriteLine("type in 3 digit number");
string yournumber = Console.ReadLine();
int a = Convert.ToInt32(yournumber);
int b;

if (a > 99 && a < 1000)
{
    b = a * 1000 + a;
    Console.WriteLine($"your number is {b}");
}
else
{
    Console.WriteLine("try again");

    goto Step1;

}