using Microsoft.EntityFrameworkCore.Migrations;
using MoscOwlAPI.Domain.Models;

namespace MoscOwlAPI.Migrations
{
    public partial class InsertGoldStatusId1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO \"Statuses\" (\"StatusId\", \"Name\", \"Description\")" +
                "VALUES (1, 'Gold', 'Gold status for Tournament')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
