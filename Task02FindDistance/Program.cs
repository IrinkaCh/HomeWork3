int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());

double result = FindDistance(xa, ya, za, xb, yb, zb);
Console.WriteLine(result);
double FindDistance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double result = Math. Sqrt(Math. Pow(xb - xa, 2)+ Math. Pow(yb - ya, 2)+ Math. Pow(zb - za, 2));
    return result;
}