﻿
namespace Tyuiu.IstominNM.Lab1.Review.V2.Lib;

public class DataService
{
    public double Calc(double x, double y)
    {
        double z = 0;

        double first_arg = (Math.Sin(x)+Math.Cos(y));
        double second_arg = (Math.Cos(x)-Math.Sin(y));
        double tan_arg = Math.Tan(x*y);

        z = (first_arg/second_arg)*tan_arg;
        double z_round = Math.Round(z, 3);
        return z_round;
    }
}
