using System.ComponentModel.DataAnnotations;
namespace USAble_proj1.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string? Discount { get; set; } = string.Empty;
        public bool Closed { get; set; } = false;
        public double Subtotal { get; set; } = 0;
        public int? BreakfastScrambler { get; set; } = 0;
        public int? VeggieBreakfastWrap { get; set; } = 0;
        public int? RoastBeef { get; set; } = 0;
        public int? RoastedTurkey { get; set; } = 0;
        public int? BelgianWaffleSlam { get; set; } = 0;
        public int? LumberjackSlam { get; set; } = 0;
        public int? SoupSalad { get; set; } = 0;
        public int? GrilledChickenSalad { get; set; } = 0;
        public int? ChefSalad { get; set; } = 0;
        public int? SideSalad { get; set; } = 0;
        public int? GrilledCheese { get; set; } = 0;
        public int? ClassicBurger { get; set; } = 0;
    }
}
