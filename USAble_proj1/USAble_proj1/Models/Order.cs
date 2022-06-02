using System.ComponentModel.DataAnnotations;
namespace USAble_proj1.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string? Discount { get; set; } = string.Empty;
        public bool Closed { get; set; } = false;
        public double Subtotal { get; set; } = 0;
        public double Total { get; set; } = 0;
        public string? BreakfastScrambler { get; set; }
        public string? VeggieBreakfastWrap { get; set; }
        public string? RoastBeef { get; set; }
        public string? RoastedTurkey { get; set; }
        public string? BelgianWaffleSlam { get; set; }
        public string? LumberjackSlam { get; set; }
        public string? SoupSalad { get; set; }
        public string? GrilledChickenSalad { get; set; }
        public string? ChefSalad { get; set; }
        public string? SideSalad { get; set; }
        public string? GrilledCheese { get; set; }
        public string? ClassicBurger { get; set; }

        public Order()
        {
            Subtotal = 0;
            Total = 0;
        }

    }

    
}
