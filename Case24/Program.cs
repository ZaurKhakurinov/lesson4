// напишите прграмму которая принимает на вход число А и выдает сумму чисел от 1 до А
Console.Clear();
Console.WriteLine("Ввведидите число: ");
int limit = int.Parse(Console.ReadLine());
Console.WriteLine ($"{limit}->{GetSum (limit)}");

int GetSum (int limit)
{
    int sum=0;
    for (int i = 1; i < limit; i++);    
        sum += i;
    return sum;
}

//  не работает