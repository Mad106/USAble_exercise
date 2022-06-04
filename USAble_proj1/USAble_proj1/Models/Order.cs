using System.ComponentModel.DataAnnotations;
namespace USAble_proj1.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string DateTime { get; set; } = string.Empty;
        public string? Name { get; set; }    // updated dbo.Order to set Name as VARCHAR(51) (25 first name + 25 last name + 1 space)
                                                // also have conditional in script of create.cshtml to enforce
        public bool Closed { get; set; } = false;   // orders that are closed can not be edited and are only seen in all orders page
        public string? Discount { get; set; } = string.Empty;   // name/type of discount
        public double DiscountNum { get; set; } = 0;    // monetary amount of discount relative to subtotal
        public double Subtotal { get; set; } = 0;
        public double PreTax { get; set; } = 0;
        public double TaxNum { get; set; } = 0;
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
