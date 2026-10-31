using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TIT.1/2");

            List<Restaurant> restaurants = new List<Restaurant>
            {
                 new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                 new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                 new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
                 new Restaurant(4, "Huguosi Snacks", " Snacks ", 4.2),
                 new Restaurant(5, "Haidilao Hot Pot", " Hot Pot ", 4.8)

            };
            foreach (var item in restaurants)
            {
                Console.WriteLine($"{item.Name} type:{item.Type} -- {item.Rate}");
            }

            int totalRestaurants = restaurants.Count;
            double averageRate = restaurants.Average(r => r.Rate);


            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"จำนวนร้านทั้งหมด: {totalRestaurants} restaurant ");
            Console.WriteLine($"ค่าเฉลี่ยคะแนนรีวิวทั้งหมด: {averageRate}");
            Console.WriteLine(new string('-', 40));


            Console.WriteLine("Chirapha26 and Pratipha12");

        }
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set;}
        public double Rate { get; set; }

        public Restaurant(int id, string name,string type,double rate)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Rate = rate;