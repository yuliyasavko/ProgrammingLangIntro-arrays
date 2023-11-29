int n = 10;
int[] arr = new int[n];
Random random  = new Random();

for(int i = 0; i < n; i++)
{
    arr[i] = random.Next();
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();

int counter = 0;
for(int i = 0; i < n; i++)
{
    if (arr[i] % 2 == 0) 
    {
        counter++;
    }
}
Console.WriteLine($"{counter}");