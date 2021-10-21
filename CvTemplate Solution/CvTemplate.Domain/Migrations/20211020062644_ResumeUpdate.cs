using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CvTemplate.Domain.Migrations
{
    public partial class ResumeUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicBackGrounds_Resumes_ResumeId",
                table: "AcademicBackGrounds");

            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Resumes_ResumeId",
                table: "Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Resumes_ResumeId",
                table: "Skills");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_Skills_ResumeId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Experiences_ResumeId",
                table: "Experiences");

            migrationBuilder.DropIndex(
                name: "IX_AcademicBackGrounds_ResumeId",
                table: "AcademicBackGrounds");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "AcademicBackGrounds");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResumeId",
                table: "Skills",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResumeId",
                table: "Experiences",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResumeId",
                table: "AcademicBackGrounds",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BioId = table.Column<int>(type: "int", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedByUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resumes_Bios_BioId",
                        column: x => x.BioId,
                        principalTable: "Bios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ResumeId",
                table: "Skills",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_ResumeId",
                table: "Experiences",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicBackGrounds_ResumeId",
                table: "AcademicBackGrounds",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_BioId",
                table: "Resumes",
                column: "BioId");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicBackGrounds_Resumes_ResumeId",
                table: "AcademicBackGrounds",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Resumes_ResumeId",
                table: "Experiences",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Resumes_ResumeId",
                table: "Skills",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
