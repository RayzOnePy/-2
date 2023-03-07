using System;

namespace ConsoleApp1;

public class Task3
{
    public class Calculation
    {
        private string calculationLine;

        public void SetCalculationLine(string line)
        {
            calculationLine = line;
        }

        public string GetCalculationLine()
        {
            return calculationLine;
        }

        public void SetLastSymbolCalculationLine(char letter)
        {
            // calculationLine = calculationLine + letter; так проще
            calculationLine = calculationLine.Insert(calculationLine.Length, letter.ToString());
        }

        public char GetLastSymbol()
        {
            return calculationLine[calculationLine.Length - 1];
        }

        public void DeleteLastSymbol()
        {
            calculationLine = calculationLine.Remove(calculationLine.Length - 1);
        }
    }
    static void Main()
    {
        Calculation calculation = new Calculation();
        calculation.SetCalculationLine("Vasiliev");
        Console.WriteLine(calculation.GetCalculationLine());
        calculation.SetLastSymbolCalculationLine('D');
        Console.WriteLine(calculation.GetCalculationLine());
        Console.WriteLine(calculation.GetLastSymbol());
        calculation.DeleteLastSymbol();
        Console.WriteLine(calculation.GetCalculationLine());
    }
}