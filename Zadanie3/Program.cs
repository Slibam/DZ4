void Zadanie2()
{
    //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
    int size = 10;
    double[] numbers = new double[size];
    FillArray(numbers);
    PrintArray(numbers);
    SumElemNe4Index(numbers);
}
void SumElemNe4Index(double[] numbers)//Поиск суммы элементов с нечётными индексами
{
    double index = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"({index}) + ({numbers[i]}) = ", 3);
            index = index + numbers[i];
            
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Cумма элементов с нечётными индексами = {index}");
}
void FillArray(double[] numb)//Создание массива
{
    Random rand = new Random();
    int Length = numb.Length;
    for (int i = 0; i < Length; i++)
    {
        numb[i] = Math.Round(rand.NextDouble() * 10, 3);     
    }
}
void PrintArray(double[] nums)//Печать массива
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