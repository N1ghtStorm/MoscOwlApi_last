using MoscOwlAPI.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoscOwlAPI.Domain.Models
{
    public class MemberTournament
    {
        public int Score { get; set; }
        public int? OwlScore { get; set; }
        public int? StatusId { get; set; }

        [JsonIgnore]
        public Status Status { get; set; }
        public int TournamentId { get; set; }

        [JsonIgnore]
        public Tournament Tournament { get; set; }
        public int MemberId { get; set; }

        [JsonIgnore]
        public Member Member { get; set; }
    }
}
