//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
using System;
using static System.Console;
Write("Enter M: ");
int a1 = int.Parse(ReadLine());
Write("Enter N: ");
int a2 = int.Parse(ReadLine());

WriteLine($"Ackerman function = {Aсkerman(a1, a2)}");

int Aсkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Aсkerman(m - 1, 1);
    return Aсkerman(m - 1, Aсkerman(m, n - 1));
}