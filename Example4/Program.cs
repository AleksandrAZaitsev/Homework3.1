System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    System.Console.WriteLine("Введите число больше 0");
}
for (int i = -number; i <= number; i++)
{
    System.Console.Write(i + ", "); 
}