System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int i = number % 10;
    System.Console.WriteLine(i);    
}
else
{
    System.Console.WriteLine("Введено не правильное число");
}
