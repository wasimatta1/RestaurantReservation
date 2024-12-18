﻿namespace RestaurantReservation.Db.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int RestaurantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public Restaurant Restaurant { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();

        override public string ToString()
        {
            return $"Employee: {FirstName} {LastName}, Position: {Position}\n";
        }

    }


}
