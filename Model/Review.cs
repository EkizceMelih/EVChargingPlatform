﻿namespace EVChargingPlatform.Model
{
    public class Review
    {

        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public int StationId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
