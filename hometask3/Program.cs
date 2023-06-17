// Задача 3 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
 int ReadInt(string message)
 {
    System.Console.Write(message);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}
int number = ReadInt("Введите целое положительное число: ");
int count = 1;
while (count <= number)
{
    Console.WriteLine(count * count * count);
    count ++;
}
