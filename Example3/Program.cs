Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1) 
{
    System.Console.WriteLine("Monday");
}
else if (day == 2)
{
    System.Console.WriteLine("Tuesday");
}
else if (day == 3)
{
    System.Console.WriteLine("Wednesday");
}
else if (day == 4)
{
    System.Console.WriteLine("Thursday");
}
else if (day == 5)
{
    System.Console.WriteLine("Friday");
}
else if (day == 6)
{
    System.Console.WriteLine("Saturday");
}
else if (day == 7)
{
    System.Console.WriteLine("Sunday");
}

else 
{
    System.Console.WriteLine("Такого дня недели нет");
}