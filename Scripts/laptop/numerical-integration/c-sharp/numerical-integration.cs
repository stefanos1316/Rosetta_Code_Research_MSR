using System;
using System.Collections.Generic;
using System.Linq;
 
public class Interval
{
    public Interval(double leftEndpoint, double size)
    {
        LeftEndpoint = leftEndpoint;
        RightEndpoint = leftEndpoint + size;
    }
 
    public double LeftEndpoint
    {
        get;
        set;
    }
 
    public double RightEndpoint
    {
        get;
        set;
    }
 
    public double Size
    {
        get
        {
            return RightEndpoint - LeftEndpoint;
        }
    }
 
    public double Center
    {
        get
        {
            return (LeftEndpoint + RightEndpoint) / 2;
        }
    }
 
    public IEnumerable<Interval> Subdivide(int subintervalCount)
    {
        double subintervalSize = Size / subintervalCount;
        return Enumerable.Range(0, subintervalCount).Select(index => new Interval(LeftEndpoint + index * subintervalSize, subintervalSize));
    }
}
 
public class DefiniteIntegral
{
    public DefiniteIntegral(Func<double, double> integrand, Interval domain)
    {
        Integrand = integrand;
        Domain = domain;
    }
 
    public Func<double, double> Integrand
    {
        get;
        set;
    }
 
    public Interval Domain
    {
        get;
        set;
    }
 
    public double SampleIntegrand(ApproximationMethod approximationMethod, Interval subdomain)
    {
        switch (approximationMethod)
        {
            case ApproximationMethod.RectangleLeft:
                return Integrand(subdomain.LeftEndpoint);
            case ApproximationMethod.RectangleMidpoint:
                return Integrand(subdomain.Center);
            case ApproximationMethod.RectangleRight:
                return Integrand(subdomain.RightEndpoint);
            case ApproximationMethod.Trapezium:
                return (Integrand(subdomain.LeftEndpoint) + Integrand(subdomain.RightEndpoint)) / 2;
            case ApproximationMethod.Simpson:
                return (Integrand(subdomain.LeftEndpoint) + 4 * Integrand(subdomain.Center) + Integrand(subdomain.RightEndpoint)) / 6;
            default:
                throw new NotImplementedException();
        }
    }
 
    public double Approximate(ApproximationMethod approximationMethod, int subdomainCount)
    {
        return Domain.Size * Domain.Subdivide(subdomainCount).Sum(subdomain => SampleIntegrand(approximationMethod, subdomain)) / subdomainCount;
    }
 
    public enum ApproximationMethod
    {
        RectangleLeft,
        RectangleMidpoint,
        RectangleRight,
        Trapezium,
        Simpson
    }
}

public class Program
{
    private static volatile int r = 1;
    private static int aVar = 0;

    public static int executeTask(int i, DefiniteIntegral integral, int subdomainCount) {

        foreach (DefiniteIntegral.ApproximationMethod approximationMethod in Enum.GetValues(typeof(DefiniteIntegral.ApproximationMethod)))
        {
		integral.Approximate(approximationMethod, subdomainCount);
        }
	return 1 + i;
    }

    private static void TestApproximationMethods(DefiniteIntegral integral, int subdomainCount)
    {
	for (aVar= 0; aVar < 100; ++aVar ) {
		r = executeTask(aVar, integral, subdomainCount);
	}
    }
 
    public static void Main()
    {
        TestApproximationMethods(new DefiniteIntegral(x => (x * x * x) + aVar, new Interval(0, 1)), 100);
        TestApproximationMethods(new DefiniteIntegral(x => 1 / (x + aVar), new Interval(1, 99)), 1000);
        TestApproximationMethods(new DefiniteIntegral(x => x + aVar, new Interval(0, 5000)), 5000000);
        TestApproximationMethods(new DefiniteIntegral(x => x + aVar, new Interval(0, 6000)), 6000000);
    }
}
