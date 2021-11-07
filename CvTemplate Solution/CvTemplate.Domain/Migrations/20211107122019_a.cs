using Microsoft.EntityFrameworkCore.Migrations;

namespace CvTemplate.Domain.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComments_BlogPostComments_ParentId1",
                table: "BlogPostComments");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComments_BlogPosts_BlogPostId1",
                table: "BlogPostComments");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComments_Users_CreatedByUserId",
                table: "BlogPostComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPostComments",
                table: "BlogPostComments");

            migrationBuilder.RenameTable(
                name: "BlogPostComments",
                newName: "BlogPostComment");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPostComments_ParentId1",
                table: "BlogPostComment",
                newName: "IX_BlogPostComment_ParentId1");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPostComments_CreatedByUserId",
                table: "BlogPostComment",
                newName: "IX_BlogPostComment_CreatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPostComments_BlogPostId1",
                table: "BlogPostComment",
                newName: "IX_BlogPostComment_BlogPostId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPostComment",
                table: "BlogPostComment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComment_BlogPostComment_ParentId1",
                table: "BlogPostComment",
                column: "ParentId1",
                principalTable: "BlogPostComment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComment_BlogPosts_BlogPostId1",
                table: "BlogPostComment",
                column: "BlogPostId1",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComment_Users_CreatedByUserId",
                table: "BlogPostComment",
                column: "CreatedByUserId",
                principalSchema: "Membership",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComment_BlogPostComment_ParentId1",
                table: "BlogPostComment");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComment_BlogPosts_BlogPostId1",
                table: "BlogPostComment");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComment_Users_CreatedByUserId",
                table: "BlogPostComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPostComment",
                table: "BlogPostComment");

            migrationBuilder.RenameTable(
                name: "BlogPostComment",
                newName: "BlogPostComments");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPostComment_ParentId1",
                table: "BlogPostComments",
                newName: "IX_BlogPostComments_ParentId1");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPostComment_CreatedByUserId",
                table: "BlogPostComments",
                newName: "IX_BlogPostComments_CreatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPostComment_BlogPostId1",
                table: "BlogPostComments",
                newName: "IX_BlogPostComments_BlogPostId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPostComments",
                table: "BlogPostComments",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComments_Users_CreatedByUserId",
                table: "BlogPostComments",
                column: "CreatedByUserId",
                principalSchema: "Membership",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
