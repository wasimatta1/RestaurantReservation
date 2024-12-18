﻿namespace RestaurantReservation.Db.Entities
{
    public class MenuItem
    {
        public int ItemId { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Restaurant Restaurant { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        override public string ToString()
        {
            return $"MenuItem: {Name}, Price: {Price}\n";
        }
    }


}
