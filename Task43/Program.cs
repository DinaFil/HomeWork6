Console.WriteLine ("Введите значение точки b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение точки k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение точки b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение точки k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindCoordinates(b1, k1, b2, k2));

string FindCoordinates (double v1, double g1, double v2, double g2)
{
double x = (v2 - v1) / (g1 - g2);
double y  = g2 * x + v2;
return ($"Координаты точки пересечения двух прямых ({x}; {y})");
}