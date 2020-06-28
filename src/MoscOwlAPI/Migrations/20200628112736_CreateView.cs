using Microsoft.EntityFrameworkCore.Migrations;

namespace MoscOwlAPI.Migrations
{
    public partial class CreateView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

           migrationBuilder.Sql(
                 $"CREATE VIEW \"MemberSeasonView\" AS" 
                  + "  SELECT \"MemberId\", \"SeasonId\", COUNT(\"MemberId\") as \"Count\", SUM(\"Score\") as \"SumScore\", SUM(\"OwlScore\") as \"SumOwlScore\""
                  + "  FROM \"MemberTournaments\""
                  + " JOIN \"Tournaments\" ON \"MemberTournaments\".\"TournamentId\" = \"Tournaments\".\"TournamentId\" "
                  + "  GROUP BY \"MemberId\", \"SeasonId\"");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "DROP VIEW \"MemberSeasonView\"");
        }
    }
}
