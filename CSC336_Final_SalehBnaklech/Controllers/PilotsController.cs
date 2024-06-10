using BLL.DTO.Pilots;
using BLL.Service.PilotService;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_Final_SalehBnaklech.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PilotsController : _GenericeController<PilotDTO>
    {
        private readonly IPilotService _pilotService;

        public PilotsController(IPilotService pilotService) : base(pilotService)
        { 
            _pilotService = pilotService;
        }
    }
}
