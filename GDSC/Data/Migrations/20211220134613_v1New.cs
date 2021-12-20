using Microsoft.EntityFrameworkCore.Migrations;

namespace GDSC.Data.Migrations
{
    public partial class v1New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendence_Member_MemberId",
                table: "Attendence");

            migrationBuilder.DropIndex(
                name: "IX_Attendence_MemberId",
                table: "Attendence");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "Attendence",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Attendence_MemberId",
                table: "Attendence",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendence_Member_MemberId",
                table: "Attendence",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendence_Member_MemberId",
                table: "Attendence");

            migrationBuilder.DropIndex(
                name: "IX_Attendence_MemberId",
                table: "Attendence");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "Attendence",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendence_MemberId",
                table: "Attendence",
                column: "MemberId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendence_Member_MemberId",
                table: "Attendence",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
