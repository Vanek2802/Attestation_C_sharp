// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N. C помощью рекурсии.

Console.Write (" Введите число М-");
int m = Convert.ToInt32 ( Console.ReadLine ());

Console.Write (" Введите число N-");
int n = Convert.ToInt32 ( Console.ReadLine ());

Sum_From_M_N ( m, n );

void Sum_From_M_N ( int m, int n )
{
    Console.Write ( SumMN ( m - 1, n));
}

int SumMN ( int m, int n)
{
    int res = m;
    if ( m == n)
        return 0;
    else 
    {
        m++;
        res = m + SumMN ( m, n );
        return res;
    }    
}