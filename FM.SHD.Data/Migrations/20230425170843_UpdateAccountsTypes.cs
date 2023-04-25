using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FM.SHD.Data.Migrations
{
    public partial class UpdateAccountsTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsClosed",
                table: "Account",
                type: "NUMERIC",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(byte[]),
                oldType: "NUMERIC",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "IsClosed",
                table: "Account",
                type: "NUMERIC",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "NUMERIC");
        }
    }
}
