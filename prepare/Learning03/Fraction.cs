using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int top_num;
    private int bot_num;

    public Fraction()
    {
        top_num = 1;
        bot_num = 1;
    }

    public Fraction(int whole_number)
    {
        top_num = whole_number;
        bot_num = 1;
    }

    public Fraction(int top, int bottom)
    {
        top_num = top;
        bot_num = bottom;
    }

    public int Get_top()
    {
        return top_num;
    }

    public void Set_top(int top)
    {
        top_num = top;
    }

    public int Get_bottom()
    {
        return bot_num;
    }

    public void Set_bottom(int bottom)
    {
        bot_num = bottom;
    }

    public string Get_fration_string()
    {
        return $"{top_num} / {bot_num}";
    }

    public double Get_decimal_value()
    {
        double dec = (double)top_num / (double)bot_num;
        return dec;
    }

}