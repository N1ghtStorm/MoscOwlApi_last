using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoscOwlAPI.Services.Extensions
{
    public static class ServiceProvider
    {
         public static void AddServiceLayer(this IServiceCollection services)
        {
            services.AddScoped<IMemberService, MemberService>();
        }
    }
}
