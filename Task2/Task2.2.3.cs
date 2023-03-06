namespace ConsoleApp4;

public class Program
{
    public class Counter
    {
        private int counter;

        public void Show()
        {
            Console.WriteLine(counter);
        }
        
        public void Increment()
        {
            counter++;
        }
        public void Decrement()
        {
            counter--;
        }

        public Counter()
        {
            counter = 0;
        }

        public Counter(int num)
        {
            counter = num;
        }
    }

    static void Main()
    {
        Counter c1 = new Counter();
        c1.Show();
        c1.Increment();
        c1.Show();

        Counter c2 = new Counter(621);
        c2.Show();
        for (int i = 0; i < 21; i++)
        {
            c2.Decrement();
        }
        c2.Show();
    }
}