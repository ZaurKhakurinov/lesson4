// принимает числа А и выдает произведение от 1 до А
Console.Clear();
Console.WriteLine("Ввведидите число: ");
int limit = int.Parse(Console.ReadLine());
Console.WriteLine ($"{limit}->{GetSum (limit)}");

int GetSum (int limit)
{
    int sum=1;
    for (int i = 1; i < limit; i++)    
        sum *= i;
    return sum;
}