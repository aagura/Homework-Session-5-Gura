//  ЗЗадайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

 double [] InitArray()
{
     int l = 0;
    while(true)
    {
        Console.WriteLine("Введите размер массива:");
        if(int.TryParse(Console.ReadLine(), out l))//23
        {
         if (l>0)  break;
         else
         {
            Console.WriteLine("Число не может быть размером массива. Повторите ввод");
        }
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    
    double [] result = new double[l];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.NextDouble ()*100;
    }

    return result;
}

void PrintArray(double [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");

    }
    Console.Write($"{arr[arr.Length-1]}]");
    Console.WriteLine();
}
double SumMaxMin (double [] arr)
{
    double result= 0;
    double Max = arr [0];
    double Min = arr [0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr [i]> Max) Max=arr [i];
        if (arr [i]< Min) Min=arr [i];        
    }
    result = Max + Min;
     return result;
}
double[] arr= InitArray ();
PrintArray (arr);
Console.WriteLine ($"Сумма минимального и максимального элемента {SumMaxMin (arr)}");