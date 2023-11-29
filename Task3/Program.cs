int n = 10;
double[] arr = new double[n];
Random random  = new Random();

for(int i = 0; i < n; i++)
{
    arr[i] = Math.Round(random.NextDouble() * 10, 2);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();

double minValue = 10;
double maxValue = 0;
for(int i = 0; i < n; i++)
{
   if (arr[i] > maxValue) 
   {
    maxValue = arr[i];
   } 
   else if (arr[i] < minValue)
   {
    minValue = arr[i];
   }
}

Console.WriteLine(Math.Round(maxValue - minValue, 2));