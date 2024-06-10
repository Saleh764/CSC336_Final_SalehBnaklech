using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories.GenericeRepository;
using DAL.Repositories.PilotRepositories;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.PilotRepository
{
    public class PilotRepository : GenericeRepository<Pilot> , IPilotRepository
    {
        public PilotRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext)
        {

        }

        

    }
}
