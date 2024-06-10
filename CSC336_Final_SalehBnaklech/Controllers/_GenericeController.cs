using BLL.Service._GenericeService;
using Microsoft.AspNetCore.Mvc;
using BLL.Wrapper;

namespace CSC336_Final_SalehBnaklech.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class _GenericeController<Dto> : Controller where Dto : class
    {
        public readonly IGenericService<Dto> _service;

        public _GenericeController(IGenericService<Dto> service)
        {
            _service = service;
        }
        [HttpGet("GetAll")]
        public ApiResponse<IEnumerable<Dto>> GetAll()
        {
            return _service.GetAll();
        }
        [HttpGet("GetById")]
        public ApiResponse<Dto> GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Add")]
        public ApiResponse<Dto> Add(Dto dto)
        {
            return _service.Add(dto);
        }

        [HttpPut("Update")]
        public ApiResponse<Dto> Update(Dto dto)
        {
            return _service.Update(dto);
        }

        [HttpDelete("DeleteById")]
        public ApiResponse<bool> DeleteById(int id)
        {
            return _service.Delete(id);
        }

        [HttpDelete("Delete")]
        public ApiResponse<bool> Delete(Dto dto)
        {
            return _service.Delete(dto);
        }



    }
}