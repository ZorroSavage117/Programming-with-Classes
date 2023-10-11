using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fac1 = new Fraction();
        Console.WriteLine(fac1.Get_fration_string());
        Console.WriteLine(fac1.Get_decimal_value());
        Fraction fac2 = new Fraction(5);
        Console.WriteLine(fac2.Get_fration_string());
        Console.WriteLine(fac2.Get_decimal_value());
        Fraction fac3 = new Fraction(3, 4);
        Console.WriteLine(fac3.Get_fration_string());
        Console.WriteLine(fac3.Get_decimal_value());
        Fraction fac4 = new Fraction();
        fac4.Set_bottom(3);
        Console.WriteLine(fac4.Get_fration_string());
        Console.WriteLine(fac4.Get_decimal_value());
    }
}