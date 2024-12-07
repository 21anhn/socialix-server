using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Socialix.Migrations
{
    /// <inheritdoc />
    public partial class ModifyDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PasswordHash = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    FullName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DoB = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    AvatarPhotoUrl = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CoverPhotoUrl = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Bio = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    UpdatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    LastLogin = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    IsActivated = table.Column<bool>(type: "bit", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__1788CC4C44F7E0F3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Followers",
                columns: table => new
                {
                    FollowerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FollowerUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    UpdatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Follower__E85940190F0BCE10", x => x.FollowerId);
                    table.ForeignKey(
                        name: "FK__Followers__Follo__7EC1CEDB",
                        column: x => x.FollowerUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Followers__UserI__7DCDAAA2",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Friendships",
                columns: table => new
                {
                    FriendshipId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId2 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    UpdatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Friendsh__4D531A54B56010B0", x => x.FriendshipId);
                    table.ForeignKey(
                        name: "FK__Friendshi__UserI__762C88DA",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Friendshi__UserI__7720AD13",
                        column: x => x.UserId2,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReceiverId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    UpdatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Messages__C87C0C9C04C857C8", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK__Messages__Receiv__7AF13DF7",
                        column: x => x.ReceiverId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Messages__Sender__79FD19BE",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Message = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    UpdatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Notifica__20CF2E126EE00242", x => x.NotificationId);
                    table.ForeignKey(
                        name: "FK__Notificat__UserI__019E3B86",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: true),
                    MediaUrl = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CreatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    UpdatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Posts__AA1260185F490794", x => x.PostId);
                    table.ForeignKey(
                        name: "FK__Posts__UserId__6ABAD62E",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    UpdatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Comments__C3B4DFCAB69B4ECA", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK__Comments__PostId__6D9742D9",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId");
                    table.ForeignKey(
                        name: "FK__Comments__UserId__6E8B6712",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    LikeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    UpdatedAt = table.Column<decimal>(type: "decimal(8,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Likes__A2922C1422E0ACE4", x => x.LikeId);
                    table.ForeignKey(
                        name: "FK__Likes__CommentId__73501C2F",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "CommentId");
                    table.ForeignKey(
                        name: "FK__Likes__PostId__725BF7F6",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId");
                    table.ForeignKey(
                        name: "FK__Likes__UserId__7167D3BD",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Followers_FollowerUserId",
                table: "Followers",
                column: "FollowerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Followers_UserId",
                table: "Followers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_UserId1",
                table: "Friendships",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_UserId2",
                table: "Friendships",
                column: "UserId2");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_CommentId",
                table: "Likes",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_PostId",
                table: "Likes",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_UserId",
                table: "Likes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__A9D1053488408B0B",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Followers");

            migrationBuilder.DropTable(
                name: "Friendships");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
