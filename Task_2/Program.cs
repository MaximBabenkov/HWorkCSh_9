// Найти сумму элементов от m до n, n и m заданы

int SumOfNumbers (int m, int n)
{
    if (m==n) return n;    
    else return n+SumOfNumbers(m,n-1);    
}
Console.Clear();
Console.Write("Enter your first number: ");
int m=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter your second number: ");
int n=int.Parse(Console.ReadLine()??"0");
if (m==n||m>n) Console.Write("The first number must be less than the second!");
else 
Console.Write($"The sum of numbers from {m} to {n}: {SumOfNumbers(m,n)}");

