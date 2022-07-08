﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] CreateArrayRndInt(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToDouble(rnd.Next(-100, 1000) / 10.0);
    }
    return arr;
}

double Difference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    double result = 0.0;
    for(int i = 0; i< arr.Length; i++)
    {
if(arr[i]< min) min = arr[i];
if(arr[i]> max) max = arr[i];
result = max - min;
    }
    return result;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");

        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
}

double[] arr = CreateArrayRndInt(size);
PrintArray(arr);
Console.WriteLine();
double  result = Difference(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {result}");
