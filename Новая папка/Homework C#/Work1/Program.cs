// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое значение :");
String inputValue1 = Console.ReadLine();

Console.Write("Введите второе значение :");
String inputValue2 = Console.ReadLine();

int value1 = Convert.ToInt32(inputValue1);
int value2 = Convert.ToInt32(inputValue2);

if (value1 < value2)
{
    System.Console.WriteLine ($"Число {value1} меньше, чем число {value2}");
}
else 
{
  System.Console.WriteLine ($"Число {value1} больше, чем число {value2}");  
}
