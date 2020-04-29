using Model;
using Repository.UserContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DriverRepository
{
    public class DriverRepository : IDriverRepository
    {
        private readonly UserContextDB userContext;

        public DriverRepository(UserContextDB userContext)
        {
            this.userContext = userContext;
        }

        public Task<int> Parkking(Parking parking)
        {
            this.userContext.ParkingSpace.Add(parking);
            var result = this.userContext.SaveChangesAsync();
            return result;
        }

        public void UnParking(long ParkingSlotId)
        {
            Parking parking=this.userContext.ParkingSpace.Find(ParkingSlotId);
            this.userContext.ParkingSpace.Remove(parking);
            this.userContext.SaveChanges();
        }
    }
}
