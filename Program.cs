/*Дана непустая последовательность целых чисел, оканчивающаяся -5. Найти: 
а)количество четных чисел последовательности; 
б)количество положительных чисел последовательности.*/

Console.WriteLine("Введите числа (последовательность заканчивается -5):");
int countEven = 0;
int countPositive = 0; 
int number;
do
{
    number = int.Parse(Console.ReadLine());
    if (number == -5)
        break; 
    if (number % 2 == 0)
    {
        countEven++;
    }
    if (number > 0) 
    {
        countPositive++;
    }
} while (true);
Console.WriteLine($"Четных чисел: {countEven}");
Console.WriteLine($"Положительных чисел: {countPositive}");