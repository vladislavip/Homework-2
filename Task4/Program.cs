/*3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;*/
Step1:

Console.Write("hi, 3 digit please: ");
string number = Console.ReadLine(); 
int a=Convert.ToInt32(number);
double b;
double c;

Console.Clear();

if (a > 99 && a < 1000)

{
    b = a * 10 + 7; //+7
    Console.WriteLine ($"your +7 is: {b}");
      
    c = b * 0.07;
    Console.WriteLine($"your 7% from +7  is: {b}");

    Console.ReadKey();
    Console.Clear();
}
else { Console.WriteLine("try again");
    goto Step1;
    
}


