using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO.Pilots;
using BLL.Service._GenericeService;
using DAL.Models;
using DAL.Repositories.GenericeRepositories;
using DAL.Repositories.PilotRepositories;

namespace BLL.Service.PilotService
{
    public class PilotService : GenericeService<Pilot, PilotDTO>, IPilotService
    {
        public readonly IPilotRepository _IpilotRepository;
        public readonly IMapper _mapper;

        public PilotService(IPilotRepository ipilotRepository, IMapper mapper) : base(ipilotRepository, mapper)
        {
            _IpilotRepository = ipilotRepository;
            _mapper = mapper;   
        }

    }

}
