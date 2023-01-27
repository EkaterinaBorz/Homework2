// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Clear();
Console.Write("Введите номер дня недели: ");

int day = int.Parse(Console.ReadLine());
switch (day)
{
  case 1: Console.WriteLine("Понедельник"); break;
  case 2: Console.WriteLine("Вторник"); break;
  case 3: Console.WriteLine("Среда"); break;
  case 4: Console.WriteLine("Четверг"); break;
  case 5: Console.WriteLine("Пятница"); break;
  case 6: Console.WriteLine("Суббота"); break;
  case 7: Console.WriteLine("Воскресенье"); break;
  default: Console.WriteLine("Такого дня недели нет!"); break;

}
if (day == 6 || day == 7) Console.WriteLine("Выходной день");
if (day < 1 && day > 7) Console.WriteLine("Такого дня недели нет ");
if (day >= 1 && day <= 5) Console.WriteLine("Рабочий день");
