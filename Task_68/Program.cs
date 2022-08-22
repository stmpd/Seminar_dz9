// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


int m = 3;
int n = 2;

int Akkerman(int numM, int numN)
{
    if(numM == 0) return numN + 1;
    else if(numM > 0 && numN == 0) return Akkerman(numM - 1, 1);
    else if(numM > 0 && numN > 0) return Akkerman(numM - 1, Akkerman(numM, numN -1));
    else return - 1;
}


int result = Akkerman(m, n);
Console.WriteLine($"m = {m}, n = {n} >>> A(m,n) = {result}");

if (result == -1)
{
    Console.Write("Функция не работает");
}