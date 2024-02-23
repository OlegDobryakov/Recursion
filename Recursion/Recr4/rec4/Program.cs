void PrintNumbers(int M, int N)
{   if(M > N)
    {   
        return;
    }
    
    Console.Write($"{M} ");
    PrintNumbers(M + 1, N);
}

PrintNumbers(5, 10);