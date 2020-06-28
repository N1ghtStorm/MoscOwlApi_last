using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoscOwlAPI.Data.Repositories
{
    public class RepositoryBase<T> where T : class
    {
        protected async Task InvokeQueryAsync(Func<Task> query)
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

        protected async Task<T> InvokeQueryAsync(Func<Task<T>> query)
        {
            try
            {
                return await query();
            }
            catch (Exception e)
            {
                throw new NotImplementedException(e.Message);
            }
        }

        protected async Task<List<T>> InvokeQueryAsync(Func<Task<List<T>>> query)
        {
            try
            {
                return await query();
            }
            catch (Exception e)
            {
                throw new NotImplementedException(e.Message);
            }
        }
    }
}
