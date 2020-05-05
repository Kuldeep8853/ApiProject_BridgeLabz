using Model;
using Repository.UserContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.OwnerRepository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly UserContextDB userContext;

        public OwnerRepository(UserContextDB userContext)
        {
            this.userContext = userContext;
        }

        public IEnumerable<Parking> GetAll()
        {
            return this.userContext.ParkingSpace.ToList();
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
            catch(ParkingLotException e)
            {
                throw e;
            }
        }

        public string UnParking(int ParkingSlotId)
        {
            try
            {
                Parking parking = this.userContext.ParkingSpace.Find(ParkingSlotId);
                if (parking == null)
                    throw new ParkingLotException("This ParkingSlotId is Empty");
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
 