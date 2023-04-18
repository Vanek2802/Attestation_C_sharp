// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N. C помощью рекурсии.

Console.Write (" Введите число М-");
int m = Conver.ToInt32 ( Console.ReadLine ());

Console.Write (" Введите число N-");
int n = Conver.ToInt32 ( Console.ReadLine ());

Sum_MN ( m, n );

void Sum_MN ( int m, int n );
{
    Console.write ( Sum_MN ( m - 1, n));
}
int Sum_MN ( int m, int n)
{
    int res = m;
    if ( m == n)
        return 0;
    else 
    {
        m++;
        res = m + Sum_MN ( m, n );
        return res;
    }    
}