using System;

namespace ConsoleApp1;

public class Task2
{
    public class Worker
    {
        private string name;
        public string Name {get{return name;}}
        
        private string surname;
        public string Surname {get{return surname;}}
        
        private int rate;
        public int Rate {get{return rate;}}
        
        private int days;
        public int Days {get{return days;}}

        public int GetSalary()
        {
            return rate * days;
        }

        public Worker(string name, string surname, int rate, int days)
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }
    }
    static void Main()
    {
        Worker worker = new Worker("Dima", "Vasiliev", 5000,365);
        Console.WriteLine(worker.GetSalary());
    }
}