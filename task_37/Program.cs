// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int[] NewArray(int[] arr)
{
       int[] array = arr.Length % 2 == 0 ? new int[arr.Length / 2] : new int[arr.Length / 2 + 1];
        for (int i = 0; i < arr.Length / 2; i++)
         {
            array[i] = arr[i] * arr[arr.Length - 1 - i];
        }
        if (arr.Length % 2 != 0) array[arr.Length / 2] = arr[arr.Length / 2];
    return array;
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

int[] array = CreateArrayRndInt(size, 0, 100);
PrintArray(array);
Console.WriteLine();
int[] newArray = NewArray(array);
PrintArray(newArray);

