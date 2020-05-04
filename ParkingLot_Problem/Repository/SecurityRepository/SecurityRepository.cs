using Model;
using Repository.UserContext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.SecurityRepository
{
    public class SecurityRepository : ISecurityRepository
    {
        private readonly UserContextDB userContext;
        

        public SecurityRepository(UserContextDB userContext)
        {
            this.userContext = userContext;
        }

        
        public Task<int> Parkking(Parking parking)
        {
            this.userContext.ParkingSpace.Add(parking);
            var result = this.userContext.SaveChangesAsync();
            return result;

        }

        public string Check_Parking_Open_Full()
        {
            int Number_Vahical = this.userContext.ParkingSpace.ToList().Count();
            if (Number_Vahical < 100)
                return "Parking Open";

            return "Parking Full";
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
