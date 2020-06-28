using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoscOwlAPI.Data.Repositories.Extensions
{
    public static class RepositoryProvider
    {
        public static void AddRepositoryLayer(this IServiceCollection services)
        {
            services.AddScoped<IMemberRepository, MemberRepository>();
        }
    }
}
