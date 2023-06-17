//Задача 1 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
int ReadInt(string message)
 {
    System.Console.Write(message);
    int input5signNum = Convert.ToInt32(Console.ReadLine());
    return input5signNum;
}
int number = ReadInt("Введите пятизначное целое число: ");

if ((number / 10000 == number % 10) && (number / 1000 % 10 == number / 10 % 10))
    { 
    Console.WriteLine($"{number}  является палиндромом");
    }
else
  { 
    Console.WriteLine($"{number} не является палиндромом"); 
  }


 
 