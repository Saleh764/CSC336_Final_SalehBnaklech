using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories.GenericeRepositories;
using DAL.Repositories.GenericeRepository;

namespace DAL.Repositories.Passengers
{
    public class PassengerRepository : GenericeRepository <Passenger> , IPassengerRepository
    {
        public PassengerRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext)
        {

        }
    }
}
