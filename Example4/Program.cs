System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = -number; i <= number; i++)
{
    System.Console.Write(i + ", "); 
}