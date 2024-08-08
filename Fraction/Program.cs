using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

public static class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите операцию с дробными числами");
            string input1 = Console.ReadLine();

            if (input1.ToLower() == "stop")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }
            
            Regex regex = new(@"^(\d+)\/(\d+)(\*|\+|\-|\/)(\d+)\/(\d+)");

            var consdition = regex.IsMatch(input1);

            if (consdition == false)
            {
                Console.WriteLine("Ошибка.Введите операцию или слово stop для выхода");
                continue;
            }

            var match = regex.Match(input1);
            var numerator1 = int.Parse(match.Groups[1].Value);
            var denumerator1 = int.Parse(match.Groups[2].Value);
            var operation = match.Groups[3].Value;
            var numerator2 = int.Parse(match.Groups[4].Value);
            var denumerator2 = int.Parse(match.Groups[5].Value);

            var frac1 = new Fractions(numerator1, denumerator1);
            var frac2 = new Fractions(numerator2, denumerator2);
            switch (operation)
            {
                case "+":
                    var sum = Fractions.Sum(frac1, frac2);
                    Console.WriteLine($"Результат: {sum}");
                    break;
                case "-":
                    var sub = Fractions.Subtraction(frac1, frac2);
                    Console.WriteLine("Результат: {sub}");
                    break;
                case "*":
                    var mult = Fractions.Multiplication(frac1, frac2);
                    Console.WriteLine("$Результат:{mult}");
                    break;
                case "/":
                    var div = Fractions.Division(frac1, frac2);
                    Console.WriteLine("$Результат:{div}");
                    break;
            }    
        }
    }
}


