using MoscOwlAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoscOwlAPI.Data
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public ICollection<MemberTournament> MemberTournaments { get; set; }
    }
}
