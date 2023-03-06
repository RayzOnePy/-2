namespace ConsoleApp1;

public class Program
{
    public class Student
    {
        private string secondName;
        private DateTime dateOfBirth;
        private int group;
        private List<int> grades = new List<int>();


        public void PrintInfo()
        {
            Console.WriteLine($"Фамилия - {secondName}\nГруппа - {group}\nДата рождения - {dateOfBirth}");
            foreach (int grade in grades)
            {
                System.Console.Write(grade + " ");
            }
            System.Console.WriteLine();
        }
        
        public void Changeinfo(string secondName)
        {
            this.secondName = secondName;
        }
        public void Changeinfo(string secondName, DateTime dateOfBirth)
        {
            this.secondName = secondName;
            this.dateOfBirth = dateOfBirth;
        }
        public void Changeinfo(string secondName, DateTime dateOfBirth, int group)
        {
            this.secondName = secondName;
            this.dateOfBirth = dateOfBirth;
            this.group = group;
        }

        public Student(string secondName, DateTime dateOfBirth, int group, List<int> grades)
        {
            this.secondName = secondName;
            this.dateOfBirth = dateOfBirth;
            this.group = group;
            this.grades = grades;
        }
    }

    static void Main()
    {
        Student dima = new Student("Beloded", new DateTime(1999, 03, 15), 912, new List<int> {5, 2, 3, 3, 4});
        dima.Changeinfo(secondName: "Vasiliev", dateOfBirth: new DateTime(2005,01,12), group: 621);
        dima.PrintInfo();
    }
}