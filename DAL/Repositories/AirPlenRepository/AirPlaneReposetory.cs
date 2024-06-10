using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories.GenericeRepository;

namespace DAL.Repositories.AirPlenRepository
{
    public class AirPlaneReposetory : GenericeRepository<Airplane>,IAirPlaneReposetory
    {
        public AirPlaneReposetory(AirplaneSystemContext airplaneSystemContext): base (airplaneSystemContext)
        {

        }
    }
}
