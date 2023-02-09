// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
 int[] InitArray()
{
     int l = 1;
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
    
    int[] result = new int[l];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next (100,999) ;
    }

    return result;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");

    }
    Console.Write($"{arr[arr.Length-1]}]");
    Console.WriteLine();
}

int CountPositive (int [] arr)
{
    int result= 0;
      for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0)
            result++;
    }

    return result;
}
int[] arr= InitArray ();
PrintArray (arr);
Console.WriteLine ($"Количество четных чисел {CountPositive (arr)}");