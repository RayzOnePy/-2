using System;

namespace Task5
{
    public class Program 
    {
        public static void Main()
        {
            // Просмотр и добавление типов машин
            DatabaseRequests.AddTypeCarQuery("Крутая");
            DatabaseRequests.GetTypeCarQuery();

            // Просмотр и добавление водителей 
            DatabaseRequests.AddDriverQuery("Димка", "Васильев", new DateTime(2005,01,12));
            DatabaseRequests.GetDriverQuery();
            
            // Просмотр и добавление водителей прав
            DatabaseRequests.GetDriverRightsCategoryQuery(1);
            DatabaseRequests.AddRightsCategoryQuery("Ы");
            
            // Просмотр и добавление машин
            DatabaseRequests.AddCarQuery(1,"жигуль","ВАЗ2109", 6);
            DatabaseRequests.GetCarQuery();

            // Просмотр и добавление маршрутов
            DatabaseRequests.AddItineraryQuery("Богашево - пл.Южная");
            DatabaseRequests.GetItineraryQuery();
            
            // Просмотр и добавление рейсов
            DatabaseRequests.AddRouteQuery(2,1,1,40);
            DatabaseRequests.GetRouteQuery();

        }
    }   
}