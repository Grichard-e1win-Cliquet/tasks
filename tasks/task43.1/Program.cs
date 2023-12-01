// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5

Console.Clear();

Console.WriteLine("Enter a number: ");

string num = Convert.ToString(int.Parse(Console.ReadLine()));

int i = 0;

while(i < num.Length)
{
    i++;
}

    Console.WriteLine($"The number has {i} digits");

Console.WriteLine($"The number has {num.Length} digits");


int number = Convert.ToInt32(num);
int cunt = 1;
count(number);

void count(int n)
{
    if(n/10 == 0)
    {

        Console.Write($"The number has {cunt} digits.");
        return;
    }
    cunt+=1;
    count(n/10);
}

Console.WriteLine();


    // if(number == 0)
    // {
    //     Console.Write($"Binary number from {num} equals ");
    //     return;
    // }
    // BinaryView(number/2);
    // Console.Write(number%2);