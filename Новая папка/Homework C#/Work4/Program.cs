//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите значение: ");
String inputValue = Console.ReadLine();

int value = Convert.ToInt32(inputValue);

int count = 1;

while(count > value)
{
    if(count % 2 ==0 )
    {
        Console.Write($" {count} ");
        count = count + 1;
    }
    else
    {
        count = count + 1;
    }
}
while(count < value)
{
    if (count % 2 == 0)
    {
        Console.Write($" {count} ");
        count++;
    }
    else
    {
        count = count + 1;
    }
}
Console.Write($"{count} ");
