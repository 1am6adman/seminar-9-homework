int Prompt(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int NaturalNum(int n, int m)
{
    if (n == m) return n;
    else Console.Write($"{NaturalNum(n, m + 1)}, ");
    return m;
}

int n = Prompt("Введите N: ");
if (n < 1)
{
    Console.WriteLine("Ввдите положительное число");
    return;
}
Console.WriteLine(NaturalNum(n, 1));