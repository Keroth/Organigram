using Microsoft.EntityFrameworkCore.Migrations;

namespace Organigram.api.Migrations
{
    public partial class CascadeDeleteOnObjectEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Objects_Objects_ParentId",
                table: "Objects");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Objects",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Objects_Objects_ParentId",
                table: "Objects",
                column: "ParentId",
                principalTable: "Objects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Objects_Objects_ParentId",
                table: "Objects");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Objects",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Objects_Objects_ParentId",
                table: "Objects",
                column: "ParentId",
                principalTable: "Objects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
