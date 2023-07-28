// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("ваше число >>> ");
int n  = Convert.ToInt16(Console.ReadLine());
for (int i = 1; i <= n; i++){
    Console.WriteLine(Math.Pow(i, 3));
}