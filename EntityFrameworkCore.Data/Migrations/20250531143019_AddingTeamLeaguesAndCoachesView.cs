using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingTeamLeaguesAndCoachesView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                Create VIEW vw_TeamsAndLeagues 
                AS
                SELECT  
                    t.Name AS TeamName, 
                    l.Name AS LeagueName 
                FROM 
                    Teams t
                LEFT JOIN Leagues l ON t.LeagueId = l.Id
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW  vw_TeamsAndLeagues");
        }
    }
}
