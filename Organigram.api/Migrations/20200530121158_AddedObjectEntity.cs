using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Organigram.api.Migrations
{
    public partial class AddedObjectEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Admin",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Editor",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Objects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedById = table.Column<int>(nullable: true),
                    ChangedById = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ChangedAt = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    Domains = table.Column<string>(nullable: true),
                    Accountabilities = table.Column<string>(nullable: true),
                    Assignee = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Objects_Users_ChangedById",
                        column: x => x.ChangedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Objects_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Objects_Objects_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Objects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Objects_ChangedById",
                table: "Objects",
                column: "ChangedById");

            migrationBuilder.CreateIndex(
                name: "IX_Objects_CreatedById",
                table: "Objects",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Objects_ParentId",
                table: "Objects",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Objects");

            migrationBuilder.DropColumn(
                name: "Admin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Editor",
                table: "Users");
        }
    }
}
