using MoscOwlAPI.Data;
using MoscOwlAPI.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoscOwlAPI.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _repository;

        public MemberService(IMemberRepository repository)
        {
            _repository = repository;
        }

        public async Task<Member> CreateMemberAsync(Member member)
        {
            return await _repository.CreateMemberAsync(member);
        }

        public async Task<List<Member>> CreateMembersAsync(List<Member> list_of_members)
        {
            return await _repository.CreateMembersAsync(list_of_members);
        }

        public async Task DeleteMemberAsync(int id)
        {
            await _repository.DeleteMemberAsync(id);
        }

        public async Task<Member> GetMemberAsync(int id)
        {
            return await _repository.GetMemberAsync(id);
        }

        public async Task<List<Member>> GetMembersAsync()
        {
            return await _repository.GetMembersAsync();
        }

        public async Task<Member> UpdateMemberAsync(Member member, int id)
        {
            return await _repository.UpdateMemberAsync(member, id);
        }
    }
}
