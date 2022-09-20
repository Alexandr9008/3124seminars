// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] GetArray(int size,int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0;i < size;i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
   return arr;
}
int SumArray(int[] Array1)
{
    int Sum = 0;
    for(int i = 1; i < Array1.Length; i+=2)
    {
        Sum += Array1[i];
    }
    return Sum;
}
int[]array = GetArray(4, -10, 100);
Console.WriteLine(string.Join(", ", array));
int Sum = SumArray(array);
Console.WriteLine(Sum);

