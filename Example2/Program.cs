Console.Write ("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
    {
        System.Console.WriteLine("Да, является");
    }

    else 
    {
        System.Console.WriteLine("Нет, не является");
    }