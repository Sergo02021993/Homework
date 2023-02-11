//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое значение :");
String inputValue1 = Console.ReadLine();

Console.Write("Введите второе значение :");
String inputValue2 = Console.ReadLine();

Console.Write("Введите третье значение :");
String inputValue3 = Console.ReadLine();

int value1 = Convert.ToInt32(inputValue1);
int value2 = Convert.ToInt32(inputValue2);
int value3 = Convert.ToInt32(inputValue3);

int max = value1;
if (value1 > max) max = value1;
if (value2 > max) max = value2;
if (value3 > max) max = value3;

Console.WriteLine($"Максимальное значение {max}");
