using Microsoft.EntityFrameworkCore;
using Model;
using Repository.UserContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PoliceRepository
{
    public class PoliceRepository:IPoliceRepository
    {
        private readonly UserContextDB userContext;

        public PoliceRepository(UserContextDB userContext)
        {
            this.userContext = userContext;
        }

        public Task<int> Parkking(Parking parking)
        {
            try
            {
                int Number_Vahical = this.userContext.ParkingSpace.ToList().Count;
                if (Number_Vahical == 100)
                    throw new ParkingLotException("This ParkingLot is full, Please move the other parking lot");
                this.userContext.ParkingSpace.Add(parking);
                var result = this.userContext.SaveChangesAsync();
                return result;
            }
            catch (ParkingLotException e)
            {
                throw e;
            }
        }

        public IEnumerable<Parking> GetDetails_Color(string color)
        {
            return this.userContext.ParkingSpace.FromSql("GetVahicalDetailsByColor {0}", color).ToList();

        }

        public IEnumerable<Parking> GetDetails_BrandName(string BrandName)
        {
            return this.userContext.ParkingSpace.FromSql("GetVahicalDetailsByBrandName {0}", BrandName).ToList();

        }

        public string UnParking(int ParkingSlotId)
        {
            try
            {
                Parking parking = this.userContext.ParkingSpace.Find(ParkingSlotId);
                if (parking == null)
                    throw new ParkingLotException("This slot id is empty");
                this.userContext.ParkingSpace.Remove(parking); 
                this.userContext.SaveChanges();
                return Utility.Receipt(parking.ChargesPerHour, parking.EntryTime);
            }
            catch (ParkingLotException e)
            {
                return e.mgs;
            }
        }

    }
}
