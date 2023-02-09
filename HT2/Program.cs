//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

 int[] InitArray()
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
    
    int[] result = new int[l];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next (-100,100) ;
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
int OddSum (int [] arr)
{
    int result= 0;
      for (int i = 1; i < arr.Length; i+=2)
    {
        result = result + arr[i];
    }

    return result;
}
int[] arr= InitArray ();
PrintArray (arr);
Console.WriteLine ($"Сумма чисел на нечетных позициях {OddSum (arr)}");