using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.UserContext
{
    public class UserContextDB:DbContext 
    {

        public UserContextDB( DbContextOptions<UserContextDB> options) : base(options)
        {
        }
        public DbSet<Parking> ParkingSpace { set; get; }
    }
}
