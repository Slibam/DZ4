void Zadanie2()
{
    //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    int size = 10;
    double[] numbers = new double[size];
    FillArray(numbers);
    PrintArray(numbers);
    Raznitca(numbers);
}
void Raznitca(double[] numbers)//Разница между макс и мин элементом массива
{   
    double max = 0;
    double min = 0;
    double Raznitca = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max) max = numbers[i];
        if (numbers[i] < min) min = numbers[i];
    }
    Console.WriteLine($"Минимальное число массива = {min}");
    Console.WriteLine($"Максимальное число массива = {max}");
    Raznitca =  Math.Abs(min)+Math.Abs(max);
    Console.WriteLine($"Разниц между максимальным и минимальным элементов массива {Raznitca}");
}
void FillArray(double[] numb)//Создание массива
{
    Random rand = new Random();
    double Length = numb.Length;
    for (int i = 0; i < Length; i++)
    {
        numb[i] = rand.Next(-10000,10000);
        numb[i] = numb[i] / 100;
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