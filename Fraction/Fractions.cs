
// задача Класс Дробное число со знаком (Fractions). Число должно быть представлено двумя полями:
// целая часть - длинное целое со знаком, дробная часть - беззнаковое короткое целое.
// Реализовать арифметические операции сложения, вычитания, умножения и операции сравнения. В функции main проверить эти методы.


// сделать хуйню для того чтоб пользователь вводил сам


class Fractions
{
    public int Numenator;      // числитель 
    public int Denumenator;   // знаменатель 

    public Fractions(int Numenator, int Denumenator)
    {
        this.Numenator = Numenator;
        this.Denumenator = Denumenator;
    }
    public static bool Validate(string input)
    {
        return true;
    }

    public static Fractions Sum(Fractions a, Fractions b)        // сложение 
    {
        int resultNum = (a.Numenator * b.Denumenator) + (b.Numenator * a.Denumenator);
        int resultDenum = a.Denumenator * b.Denumenator;

        return new Fractions(resultNum, resultDenum);
    }
    public static Fractions Subtraction(Fractions a, Fractions b)    // вычитание
    {
        int resultNum = (a.Numenator * b.Denumenator) - (b.Numenator * a.Denumenator);
        int resultDenum = a.Denumenator * b.Denumenator;

        return new Fractions(resultNum, resultDenum);
    }
    public static Fractions Multiplication(Fractions a, Fractions b)    // умножение
    {
        int resultNum = a.Numenator * b.Numenator;
        int resultDenum = a.Denumenator * b.Denumenator;

        return new Fractions(resultNum, (ushort)resultDenum);
    }
    public static Fractions Division (Fractions a, Fractions b) //деление
    {
        int resultNum = a.Numenator * b.Denumenator;
        int resultDenum = a.Denumenator * b.Numenator;
        return new Fractions(resultNum, resultDenum);
    }

    public override string? ToString()
    {
        return $"{Numenator}/{Denumenator}";
    }
}
