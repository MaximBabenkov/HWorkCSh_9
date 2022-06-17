//Показать все натуральные числа от m до n, n и m заданы

void NaturNumbers (int m, int n)
{
    if (n<m) return;    
    NaturNumbers(m,n-1);
    Console.Write(n+" ");
}
Console.Clear();
NaturNumbers(4,15);
