using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoscOwlAPI.Domain.Models
{
    public class MemberSeason
    {
        public int MemberId { get; set; }
        public int SeasonId { get; set; }
        public int Count { get; set; }
        public int SumScore { get; set; }
        public int SumOwlScore { get; set; }
    }
}
