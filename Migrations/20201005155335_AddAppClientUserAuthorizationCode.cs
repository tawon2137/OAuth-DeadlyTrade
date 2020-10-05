using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDeadlyTrade.Migrations
{
    public partial class AddAppClientUserAuthorizationCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorizationCode",
                table: "AppClientUsers",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorizationCode",
                table: "AppClientUsers");
        }
    }
}
