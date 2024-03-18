using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_writermessage_sender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "WriterMessages",
                newName: "SenderName");

            migrationBuilder.AddColumn<string>(
                name: "MessageContent",
                table: "WriterMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverName",
                table: "WriterMessages",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageContent",
                table: "WriterMessages");

            migrationBuilder.DropColumn(
                name: "ReceiverName",
                table: "WriterMessages");

            migrationBuilder.RenameColumn(
                name: "SenderName",
                table: "WriterMessages",
                newName: "Content");
        }
    }
}
