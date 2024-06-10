using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO.Passengers;
using BLL.Service._GenericeService;
using DAL.Models;
using DAL.Repositories.FlightsRepositories;
using DAL.Repositories.Passengers;

namespace BLL.services.PassengerServices
{
    public class PassengerService : GenericeService<Passenger,PassngerDto> , IPassengerService
    {
        public readonly IPassengerRepository _passengerRepository;
        public readonly IMapper _mapper;

        public PassengerService(IPassengerRepository passengerRepository, IMapper mapper) : base(passengerRepository, mapper) 
        {
            _passengerRepository = passengerRepository;
            _mapper = mapper;
        }
    }
}
