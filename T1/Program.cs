//Задача 1: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int NaturalNumber(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{NaturalNumber(n, m + 1)}, ");
  return m;
}

int n = Prompt("Input N: ");
if (n < 1)
{
  Console.WriteLine("Ввдите положительное число!");
  return;
}
Console.WriteLine(NaturalNumber(n, 1));
