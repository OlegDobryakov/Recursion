 int Ackermannfunction(int m, int n)
{
    if (m == 0)
    {
       return n + 1;
    }
   else if (m > 0 & n == 0)
    {
       return Ackermannfunction(m - 1, 1);
       
    }
    else
    {
      return Ackermannfunction(m - 1, Ackermannfunction(m, n - 1));
    }
    
}
Console.WriteLine(Ackermannfunction(3, 3));