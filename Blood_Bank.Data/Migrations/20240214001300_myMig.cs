using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blood_Bank.Data.Migrations
{
    public partial class myMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DonorsList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fNameDonor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lNameDonor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typeBloodDonor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pelephoneDonor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    statusDonor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonorsList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SicksList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fNameSick = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lNameSick = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typeBloodSick = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pelephoneSick = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    statusSick = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SicksList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DonationsList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idSick = table.Column<int>(type: "int", nullable: false),
                    SickId = table.Column<int>(type: "int", nullable: false),
                    idDonor = table.Column<int>(type: "int", nullable: false),
                    DonorId = table.Column<int>(type: "int", nullable: false),
                    statusDonation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationsList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonationsList_DonorsList_DonorId",
                        column: x => x.DonorId,
                        principalTable: "DonorsList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonationsList_SicksList_SickId",
                        column: x => x.SickId,
                        principalTable: "SicksList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DonationsList_DonorId",
                table: "DonationsList",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationsList_SickId",
                table: "DonationsList",
                column: "SickId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonationsList");

            migrationBuilder.DropTable(
                name: "DonorsList");

            migrationBuilder.DropTable(
                name: "SicksList");
        }
    }
}
