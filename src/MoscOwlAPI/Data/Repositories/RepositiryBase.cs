using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoscOwlAPI.Data.Repositories
{
    public class RepositiryBase
    {
        protected async Task ProcessQuery(Func<Task> query)
        {
            try
            {
                await query();
            }
            catch (Exception e)
            {
                throw new NotImplementedException(e.Message);
            }
        }
    }
}
