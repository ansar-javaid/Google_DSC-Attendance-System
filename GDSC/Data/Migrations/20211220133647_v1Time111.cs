using Microsoft.EntityFrameworkCore.Migrations;

namespace GDSC.Data.Migrations
{
    public partial class v1Time111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Attendence_MemberId",
                table: "Attendence");

            migrationBuilder.CreateIndex(
                name: "IX_Attendence_MemberId",
                table: "Attendence",
                column: "MemberId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Attendence_MemberId",
                table: "Attendence");

            migrationBuilder.CreateIndex(
                name: "IX_Attendence_MemberId",
                table: "Attendence",
                column: "MemberId");
        }
    }
}
