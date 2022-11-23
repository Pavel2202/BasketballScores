using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasketballScoresAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTotalScorecolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalScore",
                table: "MatchResults",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalScore",
                table: "MatchResults");
        }
    }
}
