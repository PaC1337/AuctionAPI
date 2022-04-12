using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionAPI.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auctions",
                columns: table => new
                {
                    AuctionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuctionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuctionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuctionImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuctionStartDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuctionEndDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuctionStatus = table.Column<int>(type: "int", nullable: false),
                    AuctionOwnerUserId = table.Column<int>(type: "int", nullable: false),
                    AuctionOwnerUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuctionCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuctionBidAmount = table.Column<int>(type: "int", nullable: false),
                    AuctionBidUserId = table.Column<int>(type: "int", nullable: false),
                    AuctionBidUserName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auctions", x => x.AuctionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auctions");
        }
    }
}
