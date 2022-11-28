//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
void Zadanie1()
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 950);
    PrintArray(numbers);
    PoiscChet(numbers);
}

void PoiscChet(int[] numbers)//Поиск чётных чисел в массиве
{   
    int Count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) 
        {
            Console.Write ($"{numbers[i]} ");
            Count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чётных чисел в массиве: " + Count);
}
void FillArray(int[] nums, int minZna4 = -9, int maxZna4 = 9)//Создание массива
{
    minZna4++;
    Random rand = new Random();
    int Length = nums.Length;
    for (int i = 0; i < Length; i++)
    {
        nums[i] = rand.Next(minZna4, maxZna4);
    }
}
void PrintArray(int[] nums)//Печать массива
{
    int Length = nums.Length;
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < Length; i++)
    {
        Console.Write(nums[i] + "  ");
    }
    Console.WriteLine();
    Console.WriteLine();
}
Zadanie1();
