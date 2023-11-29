// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, 
// которая определяет количество чётных чисел в массиве.

int[] FillArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] Parr)
{
    Console.Write("Массив с элементами: ");
    for(int i = 0; i < Parr.Length; i++)
    {
        Console.Write(Parr[i] + " ");
    }
}

void EvenNum(int[] num) 
{
    int[] n = new int[num.Length];
    Console.WriteLine(); 
    Console.Write("Четные: "); 
    int count= 0;

    for (int i = 0; i < num.Length; i++) 
    {
        if (num[i] % 2 == 0) 
        {
            Console.Write(num[i] + " ");
            n[count] = num[i];
            count++;
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Кол-во чeтных в массиве: {count}");
}


int[] arr = FillArray(10);
PrintArray(arr);
EvenNum(arr);
