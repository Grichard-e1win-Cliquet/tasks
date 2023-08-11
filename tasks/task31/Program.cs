Console.Clear();
Console.Write("Enter a length of massive: ");

int length = Math.Abs(int.Parse(Console.ReadLine()));
int [] arr = new int [length];

void FillArr(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
}

// Вариант решения вывода массива через инт
// int [] FillArr(int size)
// {
//     int[] arr = new int[size];
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-9,10);
//     }
//     return arr;
// }
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArr(num);

void SUM (int [] array)
{
    int SUMPOS = 0;
    int SUMNEG = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 0)
        {
            SUMPOS = SUMPOS + array[i];
        }
        else
        {
            SUMNEG = SUMNEG + array[i];
        }
    }
    Console.WriteLine($"The sum of positives numbers in array equals {SUMPOS}. ");
    Console.WriteLine($"The sum of negatives numbers in array equals {SUMNEG}. ");
}

FillArr(arr);

Console.WriteLine("Вывод массива: ");
Console.WriteLine('[' + string.Join(", ", arr) + ']');

SUM(arr);

Console.WriteLine();
