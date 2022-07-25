// Выполнить задачи обязательно с помощью рекурсии!
// Задача 64: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// void SumNumInRng(int n, int m, int sum = 0)
// {
//     if (n > m)
//     {
//         System.Console.WriteLine(sum);
//         return;
//     }
//     sum += n;
//     n++;
//     SumNumInRng(n, m, sum);
// }

// SumNumInRng(4, 8);

int Sum(int n, int m)
{
    if (n > m) return n;
    n = n + n + 1;
    return Sum(n, m) + n;
}

System.Console.WriteLine(Sum(4, 8));