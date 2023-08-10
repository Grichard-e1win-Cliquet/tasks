// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
// Console.WriteLine("Enter a massive's length: ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.Clear();

// int [] Massive = new int[length];

// void FillArr(int [] array)
// {
//     int length = array.Length;
//     int i = 0;
//     while(i < length)
//     {
        // array[i] = new Random().Next(-9999,10000);
//         i++;
//     }
// }
// void PrintArr(int [] massive)
// {
//     int qunatity = massive.Length;
//     for(int j=0; j<qunatity; j++)
//     {
//         Console.Write($"{massive[j]} ");
//     }
//     Console.WriteLine();
// }

// FillArr(Massive);
// PrintArr(Massive);
// Console.WriteLine();


Console.Write("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());

int [] arr = new int [elementsCount];

for(int i = 0; i < arr.Length; i++)
{
Console.Write($"Введите элемент массива под индексом {i}: ");
arr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Вывод массива: ");
Console.Write('[' + string.Join(", ", arr) + ']');
Console.WriteLine();