using MoscOwlAPI.Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoscOwlAPI.Data
{
    public class Member
    {
        public int MemberId { get; set; }
        [JsonRequired]
        public string Name { get; set; }
        [JsonRequired]
        public string Surname { get; set; }

        public ICollection<MemberTournament> MemberTournaments { get; set; }
    }
}
