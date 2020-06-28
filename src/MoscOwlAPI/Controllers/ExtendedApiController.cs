using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoscOwlAPI.Controllers
{
    public abstract class ExtendedApiController<T> : ControllerBase where T : class
    {
        // Service Object
        public T Service { get; }

        protected ExtendedApiController(T service)
        {
            Service = service;
        }

        protected async Task<IActionResult> ProcessQuery(Func<Task<IActionResult>> query)
        {
            try
            {
                return await query();
            }
            catch(Exception e)
            {
                //todo error handling
                return BadRequest(e.Message);
            }
        }
    }
}
