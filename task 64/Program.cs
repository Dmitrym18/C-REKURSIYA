// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int NaturalNumber(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{NaturalNumber(n, m +  1)}, ");
  return m;
}

Console.WriteLine(NaturalNumber(8, 1));




// Задача 63: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


// string ShowNumbers(int num)
// {
// if(num == 1) return "1 ";
// else return ShowNumbers(num - 1) + $"{num} ";
// }

// void Show(int number)
// {
// if(number == 1) Console.Write(1 + " ");
// else
// {
// Show(number - 1);
// Console.Write(number + " ");

// }
// }

// Console.WriteLine(ShowNumbers(5));
// Show(6);