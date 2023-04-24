// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray()
{
    int[] mass = new int [8];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(99,999);
    }
    return mass;
}

void PrintArray(int[] arr)
{
    Console.Write("{");
    Console.Write(String.Join(", ", arr));
    Console.WriteLine("}");
}

void CountEvenNumbers(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 1)
        {
            count++;
        }
    }
    Console.WriteLine("Количесво четных числе в масиве = " +count);
}


int[] arr = GetArray();
PrintArray(arr);
CountEvenNumbers(arr);

