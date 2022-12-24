// напишите программу которая выводит массив из в этементов, заполненный 0 и 1 в случайном порядке.

// void rand()
// {
//     int value = new Random().Next (2);
//     int [] array = new int [8];
//     for (i =0; i<=7; i++)
//     {
//         array[i] = new Random().Next(2);
//     }
// }

// Console.Write();

int[] array = GetBinaryArray(8);
Console.Write($"[{String.Join(",", array)}]");

int[] GetBinaryArray(int size)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }

    return result;
}