// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
Console.WriteLine("Enter a number:");
 
int A = Convert.ToInt32(Console.ReadLine());
// string? A = Convert.ToString(Console.ReadLine());
// int length = A.Length;
int result = 0;

// for(int i = 0; i<length; i++)
// {
//     result = result + A[i];
// }

while (A > 0)
{
    int num = A % 10;
    A /= 10;
    result = result + num;
}

Console.Write($"Sum of the digits in number equals {result}.");
Console.WriteLine();