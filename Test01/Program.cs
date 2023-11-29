// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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
    for(int i = 0; i<inArray.Length; i++)
    {
        Console.Write(inArray[i] + " ");
    }
    Console.WriteLine();
}

void FindNumberInArray(int num, int[] ar) // метод ищет заданное число в массиве
{
    bool flag = false;
    foreach(int element in ar) // пока element (это значение) будет находится в массиве, 
                                //будет работать цикл. Перебор всех элементов массива.
    {
        if(element == num)
        {
            flag = true;
        }
        
    }
    if (flag)  // True, проверяется истинность
    {
        Console.Write("Yes");
    }
    else
    {
        Console.Write("No");
    }
}

int[] arr = FillArray(10);