using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoscOwlAPI.Domain.Models
{
    public class Season
    {
        public int SeasonId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public ICollection<Tournament> Tournaments;
            
    }
}
