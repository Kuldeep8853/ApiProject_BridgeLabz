using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ParkingModel
    {
        [Key]
        public int ParkingSlotNo { get; set; }

        [Required]
        public string VehicalNo { get; set; }

        [Required]
        public string VehicalType { get; set; }

        public int ChargesPerHour { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public DateTime EntryTime { get; set; }

        [Required]
        public DateTime OutingTime { get; set; }

        [Required]
        public string ParkingType { get; set; }
    }
}
