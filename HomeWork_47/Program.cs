// Задайте двухмерный массив размером m x n , заполненный случайными вещественными  числами.
Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[a, b];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
void FillArrayRandomNumbers(double[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
        {
            array[i, j] =Convert.ToDouble(new Random().Next(-100,100)) / 10;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}