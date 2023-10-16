// Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Enter a length of double massive. ");

// Console.WriteLine("Enter X: ");
// int lengthX = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter Y: ");
// int lengthY = int.Parse(Console.ReadLine());

// double [,] arr = array(lengthX, lengthY);

// double [,] array (int LengthX, int LengthY)
// {
//     double [,] array = new double[LengthX, LengthY];

//     for(int i=0; i<LengthX;i++)
//     {
//         for(int j=0; j<LengthY;j++)
//         {
//             array[i, j] = new Random().NextDouble()*100;
//             Console.Write("{0,6:F2}", array[i, j]);
//         }
//     }
//     return array;
// }
// Console.WriteLine();
// Console.WriteLine("The random double massive is: " + '[' + string.Join(", ", arr) + ']' + ".");

// maxmindiff(arr);

// void maxmindiff(double [,] arr)
// {
//     double max = arr[0,0];
//     double min = arr[0,0];

//     for(int i = 0; i < lengthX; i++)
//     {
//         for(int j = 0; j<lengthY; j++)
//         {
//             if(arr[i, j] > max)
//             {
//                 max = arr[i, j];
//             }
//             else if(arr[i, j] < min)
//             {
//                 min = arr[i, j];
//             }
//         }
//     }

//     Console.WriteLine($"The difference between max ({max:F2}) and min ({min:F2}) numbers in massive equals {(max-min):F2}. ");
// }

Console.WriteLine("Enter length: ");
int length = int.Parse(Console.ReadLine());

double [] arr = array(length);

double [] array (int size)
{
    double [] array = new double[size];

    for(int i=0; i<array.Length;i++)
    {
        array[i] = new Random().Next(10,1000) + new Random().NextDouble();
    }
    return array;
}
Console.WriteLine();
Console.WriteLine("The random double massive is: " + '[' + string.Join(", ", arr) + ']' + ".");

maxmindiff(arr);

void maxmindiff(double [] arr)
{
    double max = arr[0];
    double min = arr[0];

    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
            {
                max = arr[i];
            }
        else if(arr[i] < min)
            {
                min = arr[i];
            }
    }

    // Console.WriteLine($"The difference between max ({max:F2}) and min ({min:F2}) numbers in massive equals {(max-min):F2}. ");
    Console.WriteLine($"The difference between max ({max:F2}) and min ({min:F2}) numbers in massive equals ({(max-min):F2}). ");
}