using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SYS.Dal.Migrations
{
    public partial class _24102022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stock_TransferHeaders_Stock_TransferBodies_Stock_TransferBodyTansferBodyID",
                table: "Stock_TransferHeaders");

            migrationBuilder.RenameColumn(
                name: "Stock_TransferBodyTansferBodyID",
                table: "Stock_TransferHeaders",
                newName: "Stock_TransferBodyTransferBodyID");

            migrationBuilder.RenameIndex(
                name: "IX_Stock_TransferHeaders_Stock_TransferBodyTansferBodyID",
                table: "Stock_TransferHeaders",
                newName: "IX_Stock_TransferHeaders_Stock_TransferBodyTransferBodyID");

            migrationBuilder.RenameColumn(
                name: "TransferID",
                table: "Stock_TransferBodies",
                newName: "TransferHeaderID");

            migrationBuilder.RenameColumn(
                name: "TansferBodyID",
                table: "Stock_TransferBodies",
                newName: "TransferBodyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_TransferHeaders_Stock_TransferBodies_Stock_TransferBodyTransferBodyID",
                table: "Stock_TransferHeaders",
                column: "Stock_TransferBodyTransferBodyID",
                principalTable: "Stock_TransferBodies",
                principalColumn: "TransferBodyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stock_TransferHeaders_Stock_TransferBodies_Stock_TransferBodyTransferBodyID",
                table: "Stock_TransferHeaders");

            migrationBuilder.RenameColumn(
                name: "Stock_TransferBodyTransferBodyID",
                table: "Stock_TransferHeaders",
                newName: "Stock_TransferBodyTansferBodyID");

            migrationBuilder.RenameIndex(
                name: "IX_Stock_TransferHeaders_Stock_TransferBodyTransferBodyID",
                table: "Stock_TransferHeaders",
                newName: "IX_Stock_TransferHeaders_Stock_TransferBodyTansferBodyID");

            migrationBuilder.RenameColumn(
                name: "TransferHeaderID",
                table: "Stock_TransferBodies",
                newName: "TransferID");

            migrationBuilder.RenameColumn(
                name: "TransferBodyID",
                table: "Stock_TransferBodies",
                newName: "TansferBodyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_TransferHeaders_Stock_TransferBodies_Stock_TransferBodyTansferBodyID",
                table: "Stock_TransferHeaders",
                column: "Stock_TransferBodyTansferBodyID",
                principalTable: "Stock_TransferBodies",
                principalColumn: "TansferBodyID");
        }
    }
}
