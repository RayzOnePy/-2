namespace ConsoleApp2;

public class Task2
{
    public class Train
    {
        private string stantion;
        public int id{get; private set;}
        private DateTime timeDepature;
        public void PrintInfo()
        {
            
            Console.WriteLine($"Станция - {this.stantion}\nНомер поезда - {this.id}\nВремя отправления - {this.timeDepature}");
                
        }
        
        public Train(string stantion, int id, DateTime timeDepature)
        {
            this.stantion = stantion;
            this.id = id;
            this.timeDepature = timeDepature;
        }
    }

    static void Main()
    {
        List<Train> trains = new List<Train>()
        {
            new Train("Богашево", 1, new DateTime(year : 2023, month : 2, day : 17, hour: 1, minute : 5, second : 0)),
            new Train("Лоскутого", 2, new DateTime(year : 2024, month : 2, day : 14, hour: 14, minute : 5, second : 0)),
            new Train("Аэропорт", 3, new DateTime(year : 2025, month : 2, day : 13, hour: 12, minute : 5, second : 0))
        };
        int _id = int.Parse(Console.ReadLine());
        foreach(Train train in trains)
        {
            if (train.id == _id)
                train.PrintInfo();
        }
    }
}