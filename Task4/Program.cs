Console.WriteLine("Введите число от 1 до 100000");
string input = Console.ReadLine();
int length = input.Length;
int number = int.Parse(input);
if (number >= 1 && number <= 100000)
{
    int[] arr = new int[length];
    int i = length-1;

    while (number > 0) 
    {
        int digit = number % 10;
        arr[i] = digit;
        number = number / 10;
        i--;
    }

    for(int j = 0; j < length; j++)
    {
        Console.Write($"{arr[j]} ");
    }
}
else {
    Console.WriteLine("Вы ввели не верное число");
}
