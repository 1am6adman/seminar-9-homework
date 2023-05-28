int Prompt(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int SumElem(int n, int m)
{
    if (n == m) return n;
    else return SumElem(n + 1, m) + n;
}

int m = Prompt("Введите M: ");
int n = Prompt("Введите N: ");

Console.WriteLine(SumElem(m, n));