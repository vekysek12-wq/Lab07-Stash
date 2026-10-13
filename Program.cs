// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

// for (int i = 6; i < days.Length; i--)
// {
//   Console.WriteLine($"{i}: {days[i]}");
// }

// double[] temps = { +1, +2, +3, 0, 0, -1, +2 };

// foreach (int i in  temps)
// {
//   Console.WriteLine(i);
// }

// using System.Runtime.ExceptionServices;
// int c = 0;
// int t = 0;
// int r = 0;
// int y = 0;
// int[] prices = { 120, 45, 300, 80, 15, 210 };

// foreach (int i in prices)
// {
//   c += i;
//   r += 1;
//   t = c / r;

//   if (i > 100)
//   {
//     y += 1;
//   }

// }
// ;
// Console.WriteLine(c);
// Console.WriteLine(t);
// Console.WriteLine(y);

// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int min = prices[0];
// int man = prices[0];

// for (int i = 1; i < prices.Length; i++)
// {
//   if (prices[i] < min)
//   {
//     min = prices[i];
//   }
// }

// Console.WriteLine(min);




// int[] balance = { 100, -50, 20, -5, 0, 75 };

// for (int i = 0; i < balance.Length; i++)
// {
//   if (balance[i] < 0)
//   {
//     balance[i] = 0;
//   }

// }
// foreach (int n in balance)
//   {
//     Console.Write(n + " ");
//   }



// int[] numbers = new int[5];
//         int Count = 0;

//         Console.WriteLine("Введите 5 целых чисел:");
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write($"Элемент {i + 1}: ");
//             numbers[i] = int.Parse(Console.ReadLine());

//             if (numbers[i] % 2 == 0)
//             {
//                 Count++;
//             }
//         }

//         Console.WriteLine("\nМассив в обратном порядке:");
//         for (int i = numbers.Length - 1; i >= 0; i--)
//         {
//             Console.Write(numbers[i] + " ");
//         }

//         Console.WriteLine($"\n\nКоличество чётных чисел: {Count}");

// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };

//         Console.Write("Введите имя для поиска: ");
//         string name = Console.ReadLine();

//         int index = Array.IndexOf(names, name);

// if (index != -1)
// {
//   Console.WriteLine($"Индекс в массиве (начиная с 0): {index}");
// }
// else
// {
//   Console.WriteLine("Не найдено");
// }

using System.ComponentModel.DataAnnotations;

int[] prices = { 3, 4, 4, 2, 2 };
int min = prices[0];
int max = prices[0];
double c = 0;
double t = 0;
double r = 0;
foreach (int i in prices)
{
  Console.WriteLine(i);
}
for (int i = 0; i < prices.Length; i++)
{
  c += 1;
  t += i;
  r = t / c;
  if (i < min)
  {
    min = prices[i];
  }
  if (i > max)
  {
    max = i;
  }
}
Console.WriteLine($"Среднее {r}");
Console.WriteLine($"Самая большая оценка {max}, Самая маленькая оценка {min}");
