int n = 10;
int[] arr = new int[n];
Random random  = new Random();

for(int i = 0; i < n; i++)
{
    arr[i] = random.Next(1,101);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();

int counter = 0;
for(int i = 0; i < n; i++)
{
    if (arr[i] >= 20 && arr[i] <= 90) 
    {
        counter++;
    }
}
Console.WriteLine($"{counter}");