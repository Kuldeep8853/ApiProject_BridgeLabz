using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Model
{
    public class Parking
    {
        [Key]
        public int ParkingSlotNo { get; set; }

        [Required]
        public string VehicalNo { get; set; }

        [Required]
        public string VehicalType { get; set; }

        public int ChargesPerHour { get; set; }

        [Required]
        public DateTime EntryTime { get; set; }

        [Required]
        public string DriverCategory { get; set; }

        [Required]
        public string ParkingType { get; set; }

        public Parking()
        {
            var time = DateTime.Now;
            ChargesPerHour = 10;
            EntryTime = time;
        }
    }
}
