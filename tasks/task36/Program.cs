// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.Clear();
Console.Write("Enter a length of massive: ");

int length = int.Parse(Console.ReadLine());
int [] arr = array(length);

int [] array (int Length)
{
    int [] array = new int[Length];

    for(int i=0; i<array.Length;i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}

Console.WriteLine("The random massive is: " + '[' + string.Join(",", arr) + ']' + ".");


SUM(arr);

void SUM(int [] array)
{
    int Sum = 0;

    for(int i=0; i<array.Length; i++)
    {
        if(i%2!=0)
        {
            Sum+=array[i];
        }
    }
    Console.WriteLine($"The sum of odd numbers in massive equals {Sum}.");
}