/*1) 4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. Example1: 333 = 73338*/
#region 
Step1:
Console.WriteLine("type in 4 digit number ");
string yournumber = Console.ReadLine();
int a = Convert.ToInt32(yournumber);
int b;
int c;
if (a > 999 && a < 10000)
{
    b = 7 * 10000 + a;
    c = b * 10 + 8;
    Console.WriteLine($"your  resulr is {c}");
} 
else 
{
    Console.WriteLine("try again");
    goto Step1;
}
#endregion