using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories.GenericeRepositories;
using DAL.Repositories.GenericeRepository;

namespace DAL.Repositories.FlightsRepositories
{
    public class FlightsRepository: GenericeRepository<Flight> , IFlightsRepository
    { 
        public FlightsRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext)
        {

        }

    }
}
