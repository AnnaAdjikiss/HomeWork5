// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример   [345, 897, 568, 234] -> 2
/*
void FillArray(int[] newArray)
{
     Console.Write("Массив: ");
     for (int i = 0; i < newArray.Length; i++)
     {
         newArray[i] = new Random().Next(100, 999);
         Console.Write($"{newArray[i]} ");
     }  
     Console.WriteLine();
     int count = 0;
     for (int a = 0; a < newArray.Length; a++)
     {
         if(newArray[a]%2 == 0) count++; 
     }
     Console.WriteLine($"Количество четных чисел в массиве  -  {count}");
}
Console.WriteLine("введите количество чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
FillArray(array);
Console.WriteLine();
*/

//Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//Пример:     [3, 7, 23, 12] -> 19            [-4, -6, 89, 6] -> 0
/*
void FillArray(int[] newArray)
{
     Console.Write("Массив: ");
     for (int i = 0; i < newArray.Length; i++)
     {
         newArray[i] = new Random().Next(-10, 10);
         Console.Write($"{newArray[i]} ");
     }  
     Console.WriteLine();
     int summ = 0;
     for (int a = 0; a < newArray.Length; a++)
     {
        if(a%2 != 0) summ += newArray[a]; 
     }
     Console.WriteLine($"Сумма элеентов, стоящих на нечетных позициях в массиве: {summ}.");
}
Console.WriteLine("введите количество чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
FillArray(array);
*/

//Задача 3: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//пример:   [3 7 22 2 78] -> 76

void FillArray(double[] newArray)
{
     Console.Write("Массив: ");
     for (int i = 0; i < newArray.Length; i++)
     {
         newArray[i] = new Random().Next(-10, 10);
         Console.Write($"{newArray[i]} ");
     }  
     Console.WriteLine();
     double maxValue = 0;
     double minValue = 0;
     for (int a = 0; a < newArray.Length; a++)
    {
        if(newArray[a] >= maxValue) maxValue = newArray[a]; 
        if(newArray[a] <= minValue) minValue = newArray[a]; 
    }
     double result = maxValue - minValue;
     Console.WriteLine($"Макс число в массиве: {maxValue}");
     Console.WriteLine($"Мин число в массиве: {minValue}");
     Console.WriteLine($"разницa между максимальным и минимальным элементов массива: {result}");
}
Console.WriteLine("введите количество чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N];
FillArray(array);