// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

int length = new Random().Next(1, 101);
int [] arr = randomArr (length);

int [] randomArr (int Length)
{
    int [] arr = new int [Length];

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

Console.WriteLine("The massive is: " + '[' + string.Join (",", arr) + ']' + ".");

int count = evennumbers (arr);

int evennumbers (int [] array)
{
    int count = 0;

    for(int i = 0; i<array.Length; i++)
    {
        if(array[i]%2==0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"The massive has {count} even numbers.");
