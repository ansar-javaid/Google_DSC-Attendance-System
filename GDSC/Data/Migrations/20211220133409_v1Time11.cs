using Microsoft.EntityFrameworkCore.Migrations;

namespace GDSC.Data.Migrations
{
    public partial class v1Time11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendence_Member_MemberId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Attendence_Member_MemberId",
                table: "Attendence",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendence_Member_MemberId",
                table: "Attendence");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "Attendence",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendence_Member_MemberId",
                table: "Attendence",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
