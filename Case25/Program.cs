//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//1-й вариант

// Console.Clear();
// Console.WriteLine ("введите число A: ");
// int x = int.Parse (Console.ReadLine());
// Console.WriteLine ("введите число B: ");
// int y = int.Parse (Console.ReadLine());

// Console.WriteLine ($"{Math.Pow(x, y)}");

//2 вариант
Console.WriteLine ("введите число A: ");
int x = int.Parse (Console.ReadLine());
Console.WriteLine ("введите число B: ");
int y = int.Parse (Console.ReadLine());
ToDegree(x, y);


// Функция возведения в степень
void ToDegree(int x, int y)
{
    int result = 1;
    for (int i = 1; i <= y; i++)
    {
        result = result * x;
    }
    Console.WriteLine(result);
}

