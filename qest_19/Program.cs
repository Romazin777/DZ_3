// Задача №19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
  
string palindrom5()
{
    Console.WriteLine("Введите 5 значное число");
            int numb = Convert.ToInt32(Console.ReadLine());
            string result = string.Empty;
            if (numb / 100000 >= 1) result = ("Введенное число имеет Больше 5 знаков");
            else if (numb / 10000 < 1) result = ("Введенное число имеет Меньше 5 знаков");
            else if (numb % 10 == numb / 10000 % 10 && numb / 10 % 10 == numb / 1000 % 10) result = ("Введенное число Является палиндромом");
            else result = ("Введенное число НЕ является палиндромом");
            return result;
}         
try
{
    Console.WriteLine(palindrom5());
}
catch
{
    Console.WriteLine("Введите целое 5 значное число Цифрами");
}