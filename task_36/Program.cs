// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(-10, 100);
    }
    return arr;
}

int Sum(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        result = result + array[i];
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

int[] arr = CreateArrayRndInt(size);
PrintArray(arr);
Console.WriteLine();
int sum = Sum(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");