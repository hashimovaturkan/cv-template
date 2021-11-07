using Microsoft.EntityFrameworkCore.Migrations;

namespace CvTemplate.Domain.Migrations
{
    public partial class blcomment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComments_BlogPostComments_ParentId1",
                table: "BlogPostComments");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComments_BlogPosts_BlogPostId1",
                table: "BlogPostComments");

            migrationBuilder.DropIndex(
                name: "IX_BlogPostComments_BlogPostId1",
                table: "BlogPostComments");

            migrationBuilder.DropIndex(
                name: "IX_BlogPostComments_ParentId1",
                table: "BlogPostComments");

            migrationBuilder.DropColumn(
                name: "BlogPostId1",
                table: "BlogPostComments");

            migrationBuilder.DropColumn(
                name: "ParentId1",
                table: "BlogPostComments");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "BlogPostComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BlogPostId",
                table: "BlogPostComments",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostComments_BlogPostId",
                table: "BlogPostComments",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostComments_ParentId",
                table: "BlogPostComments",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComments_BlogPostComments_ParentId",
                table: "BlogPostComments",
                column: "ParentId",
                principalTable: "BlogPostComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComments_BlogPosts_BlogPostId",
                table: "BlogPostComments",
                column: "BlogPostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComments_BlogPostComments_ParentId",
                table: "BlogPostComments");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComments_BlogPosts_BlogPostId",
                table: "BlogPostComments");

            migrationBuilder.DropIndex(
                name: "IX_BlogPostComments_BlogPostId",
                table: "BlogPostComments");

            migrationBuilder.DropIndex(
                name: "IX_BlogPostComments_ParentId",
                table: "BlogPostComments");

            migrationBuilder.AlterColumn<long>(
                name: "ParentId",
                table: "BlogPostComments",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "BlogPostId",
                table: "BlogPostComments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BlogPostId1",
                table: "BlogPostComments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentId1",
                table: "BlogPostComments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostComments_BlogPostId1",
                table: "BlogPostComments",
                column: "BlogPostId1");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostComments_ParentId1",
                table: "BlogPostComments",
                column: "ParentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComments_BlogPostComments_ParentId1",
                table: "BlogPostComments",
                column: "ParentId1",
                principalTable: "BlogPostComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComments_BlogPosts_BlogPostId1",
                table: "BlogPostComments",
                column: "BlogPostId1",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
