using System;
using System.Collections.Generic;

namespace Assignment_AuthenticationDB.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int VehicleId { get; set; }
        public string? Model { get; set; }
        public string Make { get; set; } = null!;
        public int Year { get; set; }
        public string? Color { get; set; }
        public string RegistrationNumber { get; set; } = null!;
        public bool Availability { get; set; }
        public decimal DailyRate { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
