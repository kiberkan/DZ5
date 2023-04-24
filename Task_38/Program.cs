// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int [] CreatinRandomArray()
{
    Console.WriteLine("Введите длину масива");
    int len = Convert.ToInt32(Console.ReadLine());
    if (len > 0 )
    {
    int[] arr = new int [len];   
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,100);
    }
    return arr;
    }
    else
    {
        System.Console.WriteLine("Введите длину масива (Целое и положительное число)");
        int[] arr = new int [0];
        return arr;
    }
}

void PrintArray(int [] arr)
{
    Console.Write("{");
    Console.Write(String.Join(", ", arr));
    Console.WriteLine("}");
}

void PrintDiffBetweenMaxMin(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
    if (arr[i] > max)
        {
            max = arr[i];
        }
    if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    Console.WriteLine($"Минимальное значение = {min}. Максимальное значение  = {max}. Разница = {max - min} ");
}


int[] mass = CreatinRandomArray();
PrintArray(mass);
PrintDiffBetweenMaxMin(mass);