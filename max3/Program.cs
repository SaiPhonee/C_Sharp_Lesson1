﻿// Максимальное из 3

int max(int a, int b, int c)
{
    if (a > b)
        if (a > c)
            return a;
        else
            return c;
    else
        if (b > c)
            return b;
        else
            return c;
}


Console.WriteLine(max(150, 2500, 500));