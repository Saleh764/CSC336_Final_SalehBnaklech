using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using BLL.Wrapper.NoutFondExeption;

namespace CSC336_Final_SalehBnaklech.Filter
{
    public class GlobalExceptionFilter: IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var statusCode = context.Exception switch
            {
                NotFoundExeption => StatusCodes.Status404NotFound,
            };

            context.Result = new ObjectResult(new
            {
                error = context.Exception.Message,
                stackTrace = context.Exception.StackTrace
            })
            {
                StatusCode = statusCode
            };
        }

    }
}
