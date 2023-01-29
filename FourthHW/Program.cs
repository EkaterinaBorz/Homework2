// Найти расстояние между точками в пространстве 2D/3D

Console.Clear();
Console.WriteLine();

int num = 3;            
int min = -5;               
int max = 6;                

int[] PointCoords(int num)                  
{
    int[] coords = new int[num];
    for (int i = 0; i < num; i++)
    {
        coords[i] = new Random().Next(min, max);
    }
    return coords;
}

void PrintCoords(int[] array)
{
   Console.Write($"({array[0]}, ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]})");
}

double Distance(int[] arr1, int[] arr2)
{
    int sum = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        sum = sum + (arr1[i] - arr2[i]) * (arr1[i] - arr2[i]);
    }
    double result = Math.Sqrt(sum);
    return result;
}

int[] PointA = PointCoords(num);
int[] PointB = PointCoords(num);

Console.Write($"Координаты точки А: ");
PrintCoords(PointA);
Console.Write($"Координаты точки B: ");
PrintCoords(PointB);

Console.WriteLine($"Расстояние между точками А и В: {Distance(PointA, PointB)}");
Console.WriteLine();