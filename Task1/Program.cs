// Пользователь вводит с клавиатуры число M, 
// потом вводит М числа через Enter. Посчитайте сколько чисел больше 0 ввел пользователь.

Console.Clear();
Console.WriteLine("Сколько чисел будете вводить? "); 
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввведите числа: ");
int[] numberArray = new int[number];
 
for (int i = 0; i < number; i++)
{
    numberArray[i] = int.Parse(Console.ReadLine()!);
}
 
Console.WriteLine($"Введено чисел больше 0 = {Count(numberArray)}");
 
 
int Count(int[] array)
{
    int counter = 0;
    for (int i = 0; i < number; i++)
    {
        if (array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}