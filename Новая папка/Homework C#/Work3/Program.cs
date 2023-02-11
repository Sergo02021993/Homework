//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите значение: ");
string inputValue = Console.ReadLine();

int value = Convert.ToInt32(inputValue);

if (value % 2 == 0)
{
    Console.WriteLine($"Число {value} является четным");
}
else
{
    Console.WriteLine($"Число {value} не является четным");
}