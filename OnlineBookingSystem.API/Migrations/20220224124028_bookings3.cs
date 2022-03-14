using Microsoft.EntityFrameworkCore.Migrations;

namespace OBS.API.Migrations
{
    public partial class bookings3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Leases_LeaseId",
                schema: "obs",
                table: "Bookings");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Sleepover_SleepoverType_SleepoverTypeId",
            //    schema: "obs",
            //    table: "Sleepover");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Transaction_SbuxMerchant_SbuxMerchantId",
            //    schema: "obs",
            //    table: "Transaction");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Transaction_TransactionType_TransactionTypeId",
            //    schema: "obs",
            //    table: "Transaction");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Transaction",
            //    schema: "obs",
            //    table: "Transaction");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Sleepover",
            //    schema: "obs",
            //    table: "Sleepover");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Blacklist",
            //    schema: "obs",
            //    table: "Blacklist");

            //migrationBuilder.RenameTable(
            //    name: "Transaction",
            //    schema: "obs",
            //    newName: "Transactions",
            //    newSchema: "obs");

            //migrationBuilder.RenameTable(
            //    name: "Sleepover",
            //    schema: "obs",
            //    newName: "Sleepovers",
            //    newSchema: "obs");

            //migrationBuilder.RenameTable(
            //    name: "Blacklist",
            //    schema: "obs",
            //    newName: "Blacklists",
            //    newSchema: "obs");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Transaction_TransactionTypeId",
            //    schema: "obs",
            //    table: "Transactions",
            //    newName: "IX_Transactions_TransactionTypeId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Transaction_SbuxMerchantId",
            //    schema: "obs",
            //    table: "Transactions",
            //    newName: "IX_Transactions_SbuxMerchantId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Sleepover_SleepoverTypeId",
            //    schema: "obs",
            //    table: "Sleepovers",
            //    newName: "IX_Sleepovers_SleepoverTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "LeaseId",
                schema: "obs",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Transactions",
            //    schema: "obs",
            //    table: "Transactions",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Sleepovers",
            //    schema: "obs",
            //    table: "Sleepovers",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Blacklists",
            //    schema: "obs",
            //    table: "Blacklists",
            //    column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Leases_LeaseId",
                schema: "obs",
                table: "Bookings",
                column: "LeaseId",
                principalSchema: "obs",
                principalTable: "Leases",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Sleepovers_SleepoverType_SleepoverTypeId",
            //    schema: "obs",
            //    table: "Sleepovers",
            //    column: "SleepoverTypeId",
            //    principalSchema: "obs",
            //    principalTable: "SleepoverType",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Transactions_SbuxMerchant_SbuxMerchantId",
            //    schema: "obs",
            //    table: "Transactions",
            //    column: "SbuxMerchantId",
            //    principalSchema: "obs",
            //    principalTable: "SbuxMerchant",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Transactions_TransactionType_TransactionTypeId",
            //    schema: "obs",
            //    table: "Transactions",
            //    column: "TransactionTypeId",
            //    principalSchema: "obs",
            //    principalTable: "TransactionType",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Leases_LeaseId",
                schema: "obs",
                table: "Bookings");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Sleepovers_SleepoverType_SleepoverTypeId",
            //    schema: "obs",
            //    table: "Sleepovers");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Transactions_SbuxMerchant_SbuxMerchantId",
            //    schema: "obs",
            //    table: "Transactions");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Transactions_TransactionType_TransactionTypeId",
            //    schema: "obs",
            //    table: "Transactions");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Transactions",
            //    schema: "obs",
            //    table: "Transactions");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Sleepovers",
            //    schema: "obs",
            //    table: "Sleepovers");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Blacklists",
            //    schema: "obs",
            //    table: "Blacklists");

            //migrationBuilder.RenameTable(
            //    name: "Transactions",
            //    schema: "obs",
            //    newName: "Transaction",
            //    newSchema: "obs");

            //migrationBuilder.RenameTable(
            //    name: "Sleepovers",
            //    schema: "obs",
            //    newName: "Sleepover",
            //    newSchema: "obs");

            //migrationBuilder.RenameTable(
            //    name: "Blacklists",
            //    schema: "obs",
            //    newName: "Blacklist",
            //    newSchema: "obs");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Transactions_TransactionTypeId",
            //    schema: "obs",
            //    table: "Transaction",
            //    newName: "IX_Transaction_TransactionTypeId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Transactions_SbuxMerchantId",
            //    schema: "obs",
            //    table: "Transaction",
            //    newName: "IX_Transaction_SbuxMerchantId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Sleepovers_SleepoverTypeId",
            //    schema: "obs",
            //    table: "Sleepover",
            //    newName: "IX_Sleepover_SleepoverTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "LeaseId",
                schema: "obs",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Transaction",
            //    schema: "obs",
            //    table: "Transaction",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Sleepover",
            //    schema: "obs",
            //    table: "Sleepover",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Blacklist",
            //    schema: "obs",
            //    table: "Blacklist",
            //    column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Leases_LeaseId",
                schema: "obs",
                table: "Bookings",
                column: "LeaseId",
                principalSchema: "obs",
                principalTable: "Leases",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Sleepover_SleepoverType_SleepoverTypeId",
            //    schema: "obs",
            //    table: "Sleepover",
            //    column: "SleepoverTypeId",
            //    principalSchema: "obs",
            //    principalTable: "SleepoverType",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Transaction_SbuxMerchant_SbuxMerchantId",
            //    schema: "obs",
            //    table: "Transaction",
            //    column: "SbuxMerchantId",
            //    principalSchema: "obs",
            //    principalTable: "SbuxMerchant",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Transaction_TransactionType_TransactionTypeId",
            //    schema: "obs",
            //    table: "Transaction",
            //    column: "TransactionTypeId",
            //    principalSchema: "obs",
            //    principalTable: "TransactionType",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
