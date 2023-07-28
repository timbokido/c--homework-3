// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("ваше число >>> ");
int number = Convert.ToInt16(Console.ReadLine());
int d1 = number / 10000;
int d2 = ((number / 1000) % 10);
int d4 = ((number / 10) % 10);
int d5 = number % 10;
if ((d1==d5) && (d2==d4)){
    Console.WriteLine("число " + number + " является палиндромом");
}
else {
    Console.WriteLine("число " + number + " не является палиндромом");
}
