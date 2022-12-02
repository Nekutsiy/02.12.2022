// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4];

int num = 1;
int t = 0;
int i, j = 0;
int n = array.GetLength(0);
int m = array.GetLength(1);

while (num <= array.GetLength(0) * array.GetLength(1))
{
    for (i = t; i < n; i++)
        array[j, i] = num++;
    j = n - 1;
    for (i = t + 1; i < m; i++)
        array[i, j] = num++;
    j = m - 1;
    for (i = n - 2; i >= t; i--)
        array[j, i] = num++;
    j = t;
    for (i = m - 2; i > t; i--)
        array[i, j] = num++;
    n--;
    m--;
    t++;
    j = t;
}
for (i = 0; i < array.GetLength(0); i++)
{
    for (j = 0; j < array.GetLength(1); j++)
    {
        Console.Write("{0,2} ", array[i, j]);
    }
    Console.WriteLine();
}