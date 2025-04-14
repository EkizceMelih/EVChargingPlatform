﻿namespace EVChargingPlatform.Model
{
    public class User
    {

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public string VehicleModel { get; set; }
        public string VehiclePlate { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
