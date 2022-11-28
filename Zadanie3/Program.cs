void Zadanie2()
{
    //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, -20, 20);
    PrintArray(numbers);
    SumElemNe4Index(numbers);
}
void SumElemNe4Index(int[] numbers)//Поиск суммы элементов с нечётными индексами
{
    int index = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"({index}) + ({numbers[i]}) = ");
            index = index + numbers[i];
            Console.WriteLine($"({index})");
            Console.WriteLine();
        }
    }
    Console.WriteLine($"Cумма элементов с нечётными индексами = {index}");
}
void FillArray(int[] nums, int minZna4, int maxZna4)//Создание массива
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
Zadanie2();