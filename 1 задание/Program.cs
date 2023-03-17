int read()
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
    return count;
}
Console.Clear();
Console.WriteLine("Введите несколько чисел (Через пробел): ");
int result = read();
Console.WriteLine($"Кол-во элементов > 0: {result}");