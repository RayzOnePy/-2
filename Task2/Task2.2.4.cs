namespace ConsoleApp3;

public class Program
{
    public class TwoNums
    {
        private int a;
        private int b;

        public void Print()
        {
            Console.WriteLine($"Первое число - {a} второе число - {b}");
        }

        public void Change(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Sum()
        {
            return a + b;
        }

        public int Bigest()
        {
            return a > b ? a : b;
        }
        
        public TwoNums(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }

    static void Main()
    {
        TwoNums numbers = new TwoNums(621, 18);
        numbers.Print();
        Console.WriteLine(numbers.Sum());
        Console.WriteLine(numbers.Bigest());
        numbers.Change(621, 192);
        numbers.Print();
    }
}