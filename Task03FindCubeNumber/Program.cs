int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindCubeNumber(N));

string FindCubeNumber(int N)
{
string result = "";
for (int i = 1; i <= N; i++)
{
    result += $"{Math.Pow(i,3)} ";
}
  return result;
}