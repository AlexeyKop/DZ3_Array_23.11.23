// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Задача 1: Задайте одномерный массив из 10 целых чисел  от  1  до  100.  
//Найдите  количество  элементов массива, значения которых лежат в отрезке [20,90].

Console.Clear();
int[] FillArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] InArr)
{
    Console.Write("Массив с элементами: ");
    for(int i = 0; i < InArr.Length; i++)
    {
        Console.Write(InArr[i] + " ");
    }
}

void inArray(int[] num) 
{ 
    int[] n = new int[num.Length];
    Console.WriteLine(); 
    Console.Write("Элементы массива, в отрезке [20, 90]: "); 
    int count = 0;
    for (int i = 0; i < num.Length; i++) 
    { 
        if (num[i] >= 20 && num[i] <= 90) 
        { 
            Console.Write(num[i] + " ");
            n[i] = num[i];
            count++;
        } 
    }
    
    Console.WriteLine();
    Console.WriteLine($"Кол-во элементов массива, значения которых лежат в отрезке [20,90]: {count}");
}


int[] arr = FillArray(10);
PrintArray(arr);
inArray(arr);


