using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoscOwlAPI.Domain.Models
{
    public class Tournament
    {
        public int TournamentId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }


        public int SeasonId { get; set; }

        [JsonIgnore]
        public Season Season { get; set; }

        [JsonIgnore]
        public ICollection<MemberTournament> MemberTournaments { get; set; }
    }
}
