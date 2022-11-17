namespace Services;

public class SimpleInt : IInterest
{
    private double p;
    private double r;
    private double n;
    public double  Interest(double p , double r, double n)
    {
        return p * r * n;
    }
     
}