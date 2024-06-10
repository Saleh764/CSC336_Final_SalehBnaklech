using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO.Flights;
using BLL.Service._GenericeService;
using BLL.services.FlightServices;
using DAL.Models;
using DAL.Repositories.FlightsRepositories;
using DAL.Repositories.GenericeRepositories;
using DAL.Repositories.PilotRepositories;

namespace BLL.services.FlightService
{
    public class FlightService : GenericeService<Flight,FlightDto> , IFlightSerivce
    {
            public readonly IFlightsRepository flightsRepository;
            public readonly IMapper _mapper;

        public FlightService(IFlightsRepository flightsRepository, IMapper mapper) : base(flightsRepository, mapper)
        {
        }
    }
}
