namespace ConsoleApp5;

public class Program
{
    public class Test
    {
        private int a;
        private string name;
        private bool isLearn;

        public Test()
        {
            a = 621;
            name = "Dmitriy";
            isLearn = true;
        }
        public Test(int a, string name, bool isLearn)
        {
            this.a = a;
            this.name = name;
            this.isLearn = isLearn;
        }
        
        ~Test()
        {
            Console.WriteLine("Обьект удален");
        }
    }

    static void Main()
    {
        Test test1 = new Test();
        Test test2 = new Test(621, "jen9", isLearn:false);
        test2.Dispose();
    }
}
