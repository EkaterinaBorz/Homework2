﻿//Задать номер четверти, показать диапазоны для возможных координат


Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

if (N == 1)  Console.WriteLine("x = (от '0' до бесконечности ); y = (от '0' до 'бесконечности')");

if (N == 2) Console.WriteLine("x = (от '- бесконечности' до '0'); y = (от '0' до 'бесконечности')");

if (N == 3) Console.WriteLine("x = (от '- бесконечности' до '0'); y = (от '- бесконечности' до '0')'");

if (N == 4) Console.WriteLine("X = (от '0' до 'бесконечности'); Y = (от '- бесконечности' до '0')");

if (N < 1 | N > 4) Console.WriteLine("Число N должно быть от 1 до 4");
