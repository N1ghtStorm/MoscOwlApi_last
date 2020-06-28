using MoscOwlAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoscOwlAPI.Services
{
    public interface IMemberService
    {
        Task<List<Member>> GetMembersAsync();
        Task<Member> GetMemberAsync(int id);
        Task<Member> CreateMemberAsync(Member member);
        Task<List<Member>> CreateMembersAsync(List<Member> list_of_members);
        Task<Member> UpdateMemberAsync(Member member, int id);
        Task DeleteMemberAsync(int id);
    }
}
