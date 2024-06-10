﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories.GenericeRepositories;

namespace DAL.Repositories.ReservationRepositories
{
    public interface IReservationRepository : IGenericeRepository<Reservation> 
    { 

    }
}
