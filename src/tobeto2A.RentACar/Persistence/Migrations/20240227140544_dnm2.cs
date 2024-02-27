using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dnm2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c227b45e-6aaf-4882-b0aa-45c24b557ddb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e48367de-2743-442b-a0f6-ed67310bfe1c"));

            migrationBuilder.AddColumn<int>(
                name: "ModelYear",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("539d4b04-e29f-472b-83ae-ae9de2319b17"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 36, 94, 83, 75, 227, 106, 255, 201, 78, 12, 60, 107, 217, 19, 198, 127, 78, 42, 200, 232, 172, 147, 188, 202, 247, 60, 36, 62, 169, 171, 94, 250, 210, 155, 2, 234, 193, 22, 186, 226, 230, 83, 116, 147, 129, 80, 199, 90, 154, 224, 187, 96, 84, 179, 206, 202, 155, 58, 185, 9, 84, 205, 54, 245 }, new byte[] { 74, 23, 237, 102, 180, 216, 62, 135, 76, 24, 255, 52, 7, 10, 130, 246, 81, 7, 184, 75, 205, 158, 98, 102, 241, 68, 232, 156, 45, 4, 18, 117, 58, 204, 22, 94, 21, 122, 13, 132, 198, 234, 183, 120, 189, 23, 104, 73, 23, 219, 222, 64, 143, 135, 148, 103, 96, 86, 223, 142, 104, 207, 180, 134, 94, 15, 64, 167, 44, 52, 122, 48, 169, 255, 153, 184, 155, 21, 104, 227, 95, 194, 4, 43, 12, 192, 14, 184, 83, 45, 158, 176, 6, 88, 112, 97, 104, 17, 119, 135, 224, 252, 31, 30, 217, 102, 126, 134, 86, 128, 175, 88, 115, 177, 4, 1, 67, 154, 43, 209, 83, 135, 161, 193, 38, 230, 159, 226 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("4d75f624-5c62-46d2-9a77-4019c1978798"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("539d4b04-e29f-472b-83ae-ae9de2319b17") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4d75f624-5c62-46d2-9a77-4019c1978798"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("539d4b04-e29f-472b-83ae-ae9de2319b17"));

            migrationBuilder.DropColumn(
                name: "ModelYear",
                table: "Cars");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("e48367de-2743-442b-a0f6-ed67310bfe1c"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 109, 201, 246, 218, 193, 43, 99, 147, 163, 42, 85, 241, 150, 209, 179, 70, 212, 180, 79, 163, 207, 175, 45, 31, 111, 185, 254, 213, 250, 254, 3, 92, 203, 175, 70, 53, 120, 10, 145, 91, 135, 190, 141, 146, 116, 252, 7, 88, 247, 132, 21, 109, 176, 71, 235, 113, 10, 60, 89, 157, 150, 148, 232, 143 }, new byte[] { 142, 212, 87, 15, 229, 46, 132, 70, 174, 223, 58, 54, 45, 3, 15, 29, 174, 24, 175, 14, 242, 144, 218, 45, 178, 15, 247, 150, 225, 94, 162, 215, 164, 252, 147, 227, 89, 92, 90, 89, 177, 5, 231, 6, 36, 38, 150, 52, 67, 232, 153, 89, 61, 250, 172, 60, 223, 254, 76, 86, 73, 76, 212, 182, 19, 9, 222, 58, 148, 37, 103, 59, 26, 16, 126, 135, 32, 143, 113, 202, 86, 242, 108, 68, 223, 216, 120, 67, 109, 60, 150, 163, 229, 209, 115, 164, 108, 40, 105, 206, 72, 237, 6, 254, 129, 114, 57, 229, 189, 239, 78, 46, 54, 255, 4, 91, 12, 42, 184, 144, 67, 132, 175, 253, 98, 239, 177, 2 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c227b45e-6aaf-4882-b0aa-45c24b557ddb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("e48367de-2743-442b-a0f6-ed67310bfe1c") });
        }
    }
}
