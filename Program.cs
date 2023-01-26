Console.Clear();
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] GetArrayFromConsole (int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = Convert.ToInt32 (Console.ReadLine());
    }
    return res;
}
int PositiveInArray (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( array[i] > 0 ){
            count++;
        }
    }
    return count;
}
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine ("Какое количество чисел вы хотите ввести?");
int ArraySize = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите числа через ENTER:");
int [] NewArray = GetArrayFromConsole(ArraySize);
Console.WriteLine ($"Количество положительных чисел: {PositiveInArray(NewArray)}");


