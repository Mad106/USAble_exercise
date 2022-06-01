using System.ComponentModel.DataAnnotations;

namespace USAble_proj.Pages.Orders
{
    public class Orders
    {
        [Key]
        public int ID { get; set; }
        public int OrderNum { get; set; }
        public string? Discount { get; set; } = "";
        public bool Closed { get; set; } = false;
        public double ItemCost { get; set; } = 0;

    }
}
