// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
Console.WriteLine("Enter a number:");

string? A = Convert.ToString(Console.ReadLine());
int length = A.Length;
int result = 0;

for(int i = 0; i<length; i++)
{
    result = result + A[i];
}

Console.Write($"Sum of the digits in {A} equals {result}.");
Console.Write($"{A[0]}, {A[1]}, {A[2]} {length}");
Console.WriteLine();