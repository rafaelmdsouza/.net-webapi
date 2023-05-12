using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Companies.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Employee_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_EmployeeType = table.Column<int>(type: "int", nullable: false),
                    Employee_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Employee_CurrentCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNPJ = table.Column<int>(type: "int", nullable: false),
                    CNAE = table.Column<int>(type: "int", nullable: false),
                    MonthlyIncome = table.Column<double>(type: "float", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyHistory",
                columns: table => new
                {
                    HistoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyHistory", x => x.HistoryId);
                    table.ForeignKey(
                        name: "FK_CompanyHistory_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyHistory_CompanyId",
                table: "CompanyHistory",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyHistory");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
