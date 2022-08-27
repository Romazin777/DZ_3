// Задача №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
string numbCUB()
{
    Console.Write("Введите положительное число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int i=1;
            string res = string.Empty;
            if (N < 1) res = "Нужно ввести число больше 1"
            while (i <= N)
            {
                res = res + i*i*i +", ";
                i++;
            }
    return res;
}         
try
{
    Console.WriteLine(numbCUB());
}
catch
{
    Console.WriteLine("Введите число ЦИФРАМИ");
}
