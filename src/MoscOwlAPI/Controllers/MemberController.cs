using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MoscOwlAPI.Services;

namespace MoscOwlAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ExtendedApiController<IMemberService>
    {
        public MemberController(IMemberService service) : base(service) {}

        [HttpGet] 
        /// <summary> получить всех участников (фамилия имя) </summary>
        public async Task<IActionResult> GetMembers()
        {
           return await ProcessQuery(async () =>
                 { 
                    var members = await Service.GetMembersAsync();
                     return Ok(members);
                 });
        }
    }
}
