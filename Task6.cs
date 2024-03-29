﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        var apiKey = "66c92e4a68e2ae3f43f1366dda732084";
        string city = "Semipalatinsk";
        double lat = 50.2440;
        double lon = 80.1339;
        // Корды Томск 56.4977   84.9744  Монтевидео   -34.9, -56.19
        var url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={apiKey}";
        using var client = new HttpClient();
        var response = await client.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var weather = JsonConvert.DeserializeObject<WeatherResponse>(content);
            Console.WriteLine($"Сейчас температура по координатам {lat} {lon} ({city}) составляет : {weather.Main.Temp - 273.15} °C");
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
        }
    }
}

public class WeatherResponse
{
    public MainInfo Main { get; set; }
}

public class MainInfo
{
    public double Temp { get; set; }
}