// Напишите программу, которая принимает на вход число и выдает колическтво цифр в числе.

Console.Clear();
Console.WriteLine("Ввведидите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine ($"Количество цифр = {GetCountNums (num)}");

int GetCountNums(int number)
{
    int count = 0;
    while (number>0)
    {
        count++;
        number/=10;
    }
    return count;
}
