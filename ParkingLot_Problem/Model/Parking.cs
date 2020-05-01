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
        public string VehicalBrand { get; set; }

        [Required]
        public string VahicalColore { get; set; }

        [Required]
        public int ChargesPerHour { get; set; }

        [Required]
        public DateTime EntryTime { get; set; }

        [Required]
        public string DriverCategory { get; set; }

        [Required]
        public string ParkingType { get; set; }
    }
}
