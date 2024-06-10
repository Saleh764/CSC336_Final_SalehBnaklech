using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories.GenericeRepository;

namespace DAL.Repositories.ReservationRepositories
{
    public class ReservationRepository: GenericeRepository<Reservation> , IReservationRepository
    {
        public ReservationRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext)
        {

        }

    }
}
