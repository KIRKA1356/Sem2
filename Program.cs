/*
void SumOfNum(int n1, int n2)
{
    int sum = n1 + n2;
    Console.WriteLine("Sum of ellements is " + sum);
}

 
Console.WriteLine("Введите первое число");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int Number2 = Convert.ToInt32(Console.ReadLine());
SumOfNum(Number1, Number2);
*/

/*
int MaxNumber()
{
    int Rand = new Random().Next(10,100);   
    Console.WriteLine("Corrent random number is " + Rand);

    int Dec = Rand / 10;
    int ed = Rand % 10;
    
    if (Dec > ed) return Dec;
    else return ed;
}

Console.WriteLine(MaxNumber());
*/

/*
int Preobras()
{
    int Rand = new Random().Next(100,1000);   
    Console.WriteLine("Corrent random number is " + Rand);

    int Sot = Rand / 100;
    int ed = Rand % 10;
    
    int result = Sot * 10 + ed;
    return result;
}
Console.WriteLine(Preobras());
*/

/*void Cratnost()
{
    int Rand1 = new Random().Next(1,100);
    int Rand2 = new Random().Next(1,50);
    int cratnosti = Rand2 % Rand1;
    Console.WriteLine("Первое число " + Rand1);
    Console.WriteLine("Второе число " + Rand2);
    if (cratnosti == 0) Console.WriteLine("Кратно");
    else Console.WriteLine(cratnosti);
}
Cratnost();
*/

/* void Proverca()
{
    int Rand1 = new Random().Next(1,1000); 
    Console.Write("Число " + Rand1);
    int cratnost1 = Rand1 % 7;
    int cratnost2 = Rand1 % 23;
    if (cratnost1 == 0)
        {
            if (cratnost2 == 0) Console.WriteLine(" кратно 7 и 23");
        }
    else Console.WriteLine(" не кратно 7 и 23");
}
Proverca();
*/