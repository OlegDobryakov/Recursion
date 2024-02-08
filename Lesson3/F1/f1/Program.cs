double Calculareformula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denonumenator = c + d;
    double result = numenator / denonumenator;
    return result;
}
double result = Calculareformula(1, 2, 3, 4);
Console.WriteLine(result);
