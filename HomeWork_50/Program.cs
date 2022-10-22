// Напишите программу которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или уже указание, что такого элемента нет.
// Например 1 4 7 2
//          5 9 2 3
//          8 4 2 4
// 1 ; 2   -> 4
Console.Clear();
Console.Write("Введите строку: ");
int a = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int b = Convert.ToInt32(Console.ReadLine()) - 1;
int c = 3; 
int d = 4; 
Random random = new Random();
int[,] arr = new int[c, d];
Console.WriteLine("Задан массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = random.Next(10, 99);
Console.Write("{0} ", arr[i, j]);
}
Console.WriteLine();
}
    if (a < 0 | a > arr.GetLength(0) - 1 | b < 0 | b > arr.GetLength(1) - 1)
{
Console.WriteLine("Такого элемента нет  ");
}
    else
{
    Console.WriteLine("Значение этого элемента -> {0}", arr[a, b]);
}