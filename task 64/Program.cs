// Выполнить задачи обязательно с помощью рекурсии!
// Задача 64: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumInRange(int n, int m, int sum = 0)
{
    if (n == m + 1) return sum;
    sum += n;
    n++;
    return SumInRange(n, m, sum);
}

System.Console.WriteLine(SumInRange(1, 4));