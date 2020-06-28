using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoscOwlAPI.Data.Repositories
{
    public class MemberRepository : RepositoryBase<Member>, IMemberRepository
    {
        private readonly OwlDbContext _context;

        public MemberRepository(OwlDbContext context)
        {
            _context = context;
        }

        public async Task<Member> CreateMemberAsync(Member member)
        {
            await InvokeQueryAsync(async () =>
               {
                   _context.Members.Add(member);
                   await _context.SaveChangesAsync();
               });

            return member;
        }

        public async Task<List<Member>> CreateMembersAsync(List<Member> list_of_members)
        {
            await InvokeQueryAsync(async () =>
            {
                _context.Members.AddRange(list_of_members);
                await _context.SaveChangesAsync();
            });

            return list_of_members;
        }

        public async Task DeleteMemberAsync(int id)
        {
            await InvokeQueryAsync(async () =>
            {
                var member = await _context.Members.FindAsync(id);
                _context.Members.Remove(member);
                await _context.SaveChangesAsync();
            });
        }

        public async Task<Member> GetMemberAsync(int id)
        {
            return await InvokeQueryAsync(async () =>
            {
                return await _context.Members.FindAsync(id);
            });
        }

        public async Task<List<Member>> GetMembersAsync()
        {
            return await InvokeQueryAsync(async () =>
            {
                return await _context.Members.ToListAsync();
            });
        }

        public async Task<Member> UpdateMemberAsync(Member member, int id)
        {
            await InvokeQueryAsync(async () =>
            {
                member.MemberId = id;
                _context.Members.Update(member);
                await _context.SaveChangesAsync();
            });

            return member;
        }
    }
}
