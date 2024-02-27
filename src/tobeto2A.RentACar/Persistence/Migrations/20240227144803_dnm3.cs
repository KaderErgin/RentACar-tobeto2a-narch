using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dnm3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndividualCustomers_Customers_CustomerId",
                table: "IndividualCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IndividualCustomers",
                table: "IndividualCustomers");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4d75f624-5c62-46d2-9a77-4019c1978798"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("539d4b04-e29f-472b-83ae-ae9de2319b17"));

            migrationBuilder.RenameTable(
                name: "IndividualCustomers",
                newName: "InvidualCustomers");

            migrationBuilder.RenameIndex(
                name: "IX_IndividualCustomers_CustomerId",
                table: "InvidualCustomers",
                newName: "IX_InvidualCustomers_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvidualCustomers",
                table: "InvidualCustomers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("2a15b461-f6af-4817-9602-cb33f064055a"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 205, 180, 170, 11, 11, 152, 142, 169, 219, 233, 126, 13, 102, 2, 147, 103, 80, 193, 214, 28, 245, 75, 251, 157, 6, 159, 251, 175, 210, 172, 118, 85, 179, 238, 101, 43, 72, 68, 38, 194, 178, 59, 203, 192, 141, 129, 100, 194, 68, 83, 48, 85, 222, 5, 115, 45, 239, 83, 40, 216, 78, 53, 33, 236 }, new byte[] { 30, 134, 146, 249, 188, 236, 101, 190, 26, 193, 211, 54, 40, 206, 27, 91, 224, 178, 121, 204, 16, 245, 191, 200, 3, 15, 25, 78, 248, 228, 165, 153, 71, 24, 228, 95, 85, 211, 35, 211, 243, 153, 183, 37, 68, 219, 73, 146, 38, 162, 109, 20, 35, 166, 234, 81, 174, 37, 122, 178, 171, 172, 249, 29, 186, 83, 118, 92, 164, 20, 88, 73, 20, 137, 189, 216, 236, 22, 66, 13, 1, 9, 233, 92, 161, 69, 185, 209, 236, 14, 54, 182, 45, 247, 145, 157, 221, 78, 214, 56, 139, 136, 3, 12, 86, 237, 231, 90, 204, 189, 12, 253, 88, 60, 181, 57, 24, 158, 34, 95, 244, 206, 176, 0, 222, 234, 51, 146 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("73b20ec8-5415-465c-bb09-b9edb10f65c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("2a15b461-f6af-4817-9602-cb33f064055a") });

            migrationBuilder.AddForeignKey(
                name: "FK_InvidualCustomers_Customers_CustomerId",
                table: "InvidualCustomers",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvidualCustomers_Customers_CustomerId",
                table: "InvidualCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvidualCustomers",
                table: "InvidualCustomers");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("73b20ec8-5415-465c-bb09-b9edb10f65c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a15b461-f6af-4817-9602-cb33f064055a"));

            migrationBuilder.RenameTable(
                name: "InvidualCustomers",
                newName: "IndividualCustomers");

            migrationBuilder.RenameIndex(
                name: "IX_InvidualCustomers_CustomerId",
                table: "IndividualCustomers",
                newName: "IX_IndividualCustomers_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IndividualCustomers",
                table: "IndividualCustomers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("539d4b04-e29f-472b-83ae-ae9de2319b17"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 36, 94, 83, 75, 227, 106, 255, 201, 78, 12, 60, 107, 217, 19, 198, 127, 78, 42, 200, 232, 172, 147, 188, 202, 247, 60, 36, 62, 169, 171, 94, 250, 210, 155, 2, 234, 193, 22, 186, 226, 230, 83, 116, 147, 129, 80, 199, 90, 154, 224, 187, 96, 84, 179, 206, 202, 155, 58, 185, 9, 84, 205, 54, 245 }, new byte[] { 74, 23, 237, 102, 180, 216, 62, 135, 76, 24, 255, 52, 7, 10, 130, 246, 81, 7, 184, 75, 205, 158, 98, 102, 241, 68, 232, 156, 45, 4, 18, 117, 58, 204, 22, 94, 21, 122, 13, 132, 198, 234, 183, 120, 189, 23, 104, 73, 23, 219, 222, 64, 143, 135, 148, 103, 96, 86, 223, 142, 104, 207, 180, 134, 94, 15, 64, 167, 44, 52, 122, 48, 169, 255, 153, 184, 155, 21, 104, 227, 95, 194, 4, 43, 12, 192, 14, 184, 83, 45, 158, 176, 6, 88, 112, 97, 104, 17, 119, 135, 224, 252, 31, 30, 217, 102, 126, 134, 86, 128, 175, 88, 115, 177, 4, 1, 67, 154, 43, 209, 83, 135, 161, 193, 38, 230, 159, 226 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("4d75f624-5c62-46d2-9a77-4019c1978798"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("539d4b04-e29f-472b-83ae-ae9de2319b17") });

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualCustomers_Customers_CustomerId",
                table: "IndividualCustomers",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
