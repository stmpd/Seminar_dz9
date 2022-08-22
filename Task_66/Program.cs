// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int min = m;

int NumberSum(int numM, int numN)
{
    int sum = 0;

    if(numN < min) return 0;
        sum += NumberSum(numM + 1, numN - 1) + numM;

    return sum;
}

int result = NumberSum(m, n);
Console.WriteLine($"{m}, {n} >>> {result}");