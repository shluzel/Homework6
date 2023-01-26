Console.Clear();
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] GetArrayFromConsole(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = Convert.ToInt32(Console.ReadLine());
    }
    return res;
}
double[] GetArrayFromConsoleDouble(int size)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = Convert.ToDouble(Console.ReadLine());
    }
    return result;
}
int PositiveInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
double[] PointForLines(double[] array1, double[] array2)
{
    double[] res = new double[2];
    res[0] = (array1[1] - array2[1]) / (array1[0] - array2[0]);
    res[1] = array1[0] * res[0] + array1[1];
    return res;
}
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("Какое количество чисел вы хотите ввести?");
int ArraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа через ENTER:");
int[] NewArray = GetArrayFromConsole(ArraySize);
Console.WriteLine($"Количество положительных чисел: {PositiveInArray(NewArray)}");
*/

//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите числа K1 и B1 через ENTER в заданном порядке:");
double[] FirstLine = GetArrayFromConsoleDouble(2);
Console.WriteLine("Введите числа K2 и B2 через ENTER в заданном порядке:");
double[] SecondLine = GetArrayFromConsoleDouble(2);
if (FirstLine[0] == SecondLine[0])
{
    Console.WriteLine("Линии параллельны. Точки пересечения нет.");
}
else
{
    Console.Write("Точка пересечения: ");
    ShowArray(PointForLines(FirstLine, SecondLine));
}
