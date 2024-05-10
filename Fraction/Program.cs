

class Program
{
    static void Main()
    {
        Fractions frac1 = new Fractions(4, 8);
        Fractions frac2 = new Fractions(8, 16);

        Fractions sum = Fractions.Sum(frac1, frac2);
        Fractions sub = Fractions.Subtraction(frac1, frac2);
        Fractions mult = Fractions.Multiplication(frac1, frac2);

        Console.WriteLine("Fraction 1: {0}.{1}", frac1.Numenator, frac2.Denumenator);
        Console.WriteLine("Fraction 2: {0}.{1}", frac1.Numenator, frac2.Denumenator);
        Console.WriteLine("Sum: {0}.{1}", sum.Numenator, sum.Denumenator);
        Console.WriteLine("Subtraction: {0}.{1}", sub.Numenator, sub.Denumenator);
        Console.WriteLine("Multiplication: {0}.{1}", mult.Numenator, mult.Denumenator);
        Console.WriteLine("Compare result: " + Fractions.Compare(frac1, frac2));
    }
}
