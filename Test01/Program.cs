// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Задача 1: Задайте одномерный массив из 10 целых чисел  от  1  до  100.  
//Найдите  количество  элементов массива, значения которых лежат в отрезке [20,90].

int [] FillArray(int size) // Метод который заполняет массив
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] inArray)  
{
    int count = 0;
    for(int i = 0   ; i<inArray.Length; i++)
    {
        if (inArray[i] >= 20 & inArray[i] <= 90)
        count++;
        Console.Write(inArray[i] + " ");
    }
    Console.WriteLine("кол-во  элементов массива, в отрезке [20,90]: ", count);
}

int[] arr = FillArray(10);
PrintArray(arr);

