using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO.Pilots;
using BLL.Service._GenericeService;
using BLL.Wrapper;
using DAL.Repositories.GenericeRepositories;

namespace BLL.Service.PilotService
{
    public interface IPilotService : IGenericService<PilotDTO>
    {
     
    }
}
