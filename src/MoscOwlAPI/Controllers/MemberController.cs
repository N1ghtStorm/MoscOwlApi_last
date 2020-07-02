using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MoscOwlAPI.Data;
using MoscOwlAPI.Services;

namespace MoscOwlAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ExtendedApiController<IMemberService>
    {
        public MemberController(IMemberService service) : base(service) { }

        [HttpGet]
        /// <summary> получить всех участников (фамилия имя) </summary>
        public async Task<IActionResult> GetMembers()
        {
            return await ProcessQuery(async () =>
                  {
                      var result = await Service.GetMembersAsync();
                      return Ok(result);
                  });
        }

        [HttpGet("{id}")]
        /// <summary> получить всех участников (фамилия имя) </summary>
        public async Task<IActionResult> GetMember(int id)
        {
            return await ProcessQuery(async () =>
            {
                throw new NotImplementedException();
            });
        }

        [HttpPost]
        public async Task<IActionResult> CreateMembers([FromBody] Member member)
        {
            return await ProcessQuery(async () =>
            {
                var result = await Service.CreateMemberAsync(member);
                return Created("", result);
            });
        }

        [HttpPost]
        [Route("/many/")]
        public async Task<IActionResult> CreateMembers([FromBody] List<Member> list_of_members)
        {
            return await ProcessQuery(async () =>
            {
                var result = await Service.CreateMembersAsync(list_of_members);
                return Created("", result);
            });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMember([FromBody] Member member, int id)
        {
            return await ProcessQuery(async () =>
            {
                if (member?.MemberId != 0 && member.MemberId != id)
                {
                    throw new Exception("Ids don't match");
                }

                var result = await Service.UpdateMemberAsync(member, id);
                return Ok(result);
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMember(int id)
        {
            return await ProcessQuery(async () =>
            {
                await Service.DeleteMemberAsync(id);
                return Ok();
            });
        }
    }
}
