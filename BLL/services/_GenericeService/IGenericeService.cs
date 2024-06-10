using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Wrapper;

namespace BLL.Service._GenericeService
{
    public interface IGenericService<Dto> where Dto : class
    {
        ApiResponse<IEnumerable<Dto>> GetAll();
        ApiResponse<Dto> GetById(int id);
        ApiResponse<Dto> Add(Dto faculty);
        ApiResponse<Dto> Update(Dto faculty);
        ApiResponse<bool> Delete(int id);
        ApiResponse<bool> Delete(Dto faculty);
    }
}
