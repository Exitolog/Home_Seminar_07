
void Main()
{
int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
PrintNumbers(m,n);
int ReadInt (string msg)
{
Console.WriteLine(msg);
return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int m, int n)
{
    if (m <= n)
 {
if (m == n) return;
System.Console.Write(m + " ");
PrintNumbers(m+1, n);
//System.Console.Write(m + " ");
}
else if (m >= n)
{
if (m == n) return;
System.Console.Write(m + " ");
PrintNumbers(m-1, n);
//System.Console.Write(m + " ");
}

}
}
Main();