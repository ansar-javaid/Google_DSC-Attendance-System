using Microsoft.EntityFrameworkCore.Migrations;

namespace GDSC.Data.Migrations
{
    public partial class vM12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_Event_EventId",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "EventName",
                table: "Member");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Member",
                newName: "MemberId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Event",
                newName: "EventId");

            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "Member",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TicketPrice",
                table: "Member",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Event_EventId",
                table: "Member",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_Event_EventId",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "TicketPrice",
                table: "Member");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "Member",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Event",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "Member",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "EventName",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Event_EventId",
                table: "Member",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
