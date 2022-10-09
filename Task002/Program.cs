// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void InputIndex(double[,] ind)
{
  for (int i = 0; i < ind.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < ind.GetLength(1); j++)
    {
        if(j==0) 
        {
          Console.WriteLine($"Введите коэффициент k: ");
        }
        else 
        {
          Console.WriteLine($"Введите коэффициент b: ");
        }
        ind[i,j] = int.Parse(Console.ReadLine()!);
    }
  }
}

double[] Resolve(double[] Intersection, double[,] ind)
{
  Intersection[0] = (ind[1,1] - ind[0,1]) / (ind[0,0] - ind[1,0]);
  Intersection[1] = Intersection[0] * ind[0,0] + ind[0,1];
  return Intersection;
}

void derivation(double[] Intersection, double[,] ind)
{
  if (ind[0,0] == ind[1,0] && ind[0,1] == ind[1,1]) 
  {
    Console.Write("Прямые совпадают");
  }
  else if (ind[0,0] == ind[1,0] && ind[0,1] != ind[1,1]) 
  {
    Console.Write("Прямые параллельны");
  }
  else 
  {
    Resolve(Intersection, ind);
    Console.Write($"Точка пересечения прямых: ({Intersection[0]}, {Intersection[1]})");
  }
}

double[,] ind = new double[2, 2];
double[] Intersection = new double[2];

InputIndex(ind);
derivation(Intersection, ind);