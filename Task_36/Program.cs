// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int [] GetRandomArray()
{
    int [] arr = new int [8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100,100);
    }
    return arr;
}

void PrintArray(int [] arr)
{
    Console.Write("{");
    Console.Write(String.Join(", ", arr));
    Console.WriteLine("}");
}

void SumOfOddPositions(int[] arr)
{   
    int sum = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        sum = sum + arr[i];
    }
    System.Console.WriteLine("Сума элементов стоящих на нечетных позициях = " + sum);
}

int[] mass = GetRandomArray();
PrintArray(mass);
SumOfOddPositions(mass);