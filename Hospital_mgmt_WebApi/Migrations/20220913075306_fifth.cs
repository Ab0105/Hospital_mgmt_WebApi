using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital_mgmt_WebApi.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Bill_Data__Docto__4CA06362",
                table: "Bill_Data");

            migrationBuilder.DropForeignKey(
                name: "FK__Bill_Data__Pid__4BAC3F29",
                table: "Bill_Data");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Bill_Dat__CF6FA49F09167DB9",
                table: "Bill_Data");

            migrationBuilder.DropColumn(
                name: "Operation_Charge",
                table: "Bill_Data");

            migrationBuilder.DropColumn(
                name: "Room_Charge",
                table: "Bill_Data");

            migrationBuilder.RenameColumn(
                name: "Total_Days",
                table: "Bill_Data",
                newName: "Total_days");

            migrationBuilder.RenameColumn(
                name: "Total_amount",
                table: "Bill_Data",
                newName: "Total_Amount");

            migrationBuilder.RenameColumn(
                name: "Doctor_id",
                table: "Bill_Data",
                newName: "Doctor_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_Data_Doctor_id",
                table: "Bill_Data",
                newName: "IX_Bill_Data_Doctor_Id");

            migrationBuilder.AlterColumn<int>(
                name: "Total_days",
                table: "Bill_Data",
                nullable: true,
                defaultValueSql: "((0))",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Patient_Type",
                table: "Bill_Data",
                unicode: false,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(1)",
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<decimal>(
                name: "Medicine_Fees",
                table: "Bill_Data",
                type: "numeric(18, 0)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Lab_Fees",
                table: "Bill_Data",
                type: "numeric(18, 0)",
                nullable: true,
                defaultValueSql: "((0))",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Doctor_Fees",
                table: "Bill_Data",
                type: "numeric(18, 0)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Bill_No",
                table: "Bill_Data",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1)",
                oldUnicode: false,
                oldMaxLength: 1)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<decimal>(
                name: "Operation_Charges",
                table: "Bill_Data",
                type: "numeric(18, 0)",
                nullable: true,
                defaultValueSql: "((0))");

            migrationBuilder.AddColumn<decimal>(
                name: "Room_Charges",
                table: "Bill_Data",
                type: "numeric(18, 0)",
                nullable: true,
                defaultValueSql: "((0))");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total_Amount",
                table: "Bill_Data",
                type: "numeric(33, 0)",
                nullable: true,
                computedColumnSql: "(((([Doctor_Fees]+[Room_Charges]*[Total_days])+[Operation_Charges])+[Medicine_Fees])+[Lab_Fees])",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__Bill_Dat__CF6FA49F05935736",
                table: "Bill_Data",
                column: "Bill_No");

            migrationBuilder.AddForeignKey(
                name: "FK__Bill_Data__Docto__114A936A",
                table: "Bill_Data",
                column: "Doctor_Id",
                principalTable: "Doctor",
                principalColumn: "Doctor_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Bill_Data__Pid__10566F31",
                table: "Bill_Data",
                column: "Pid",
                principalTable: "Patient",
                principalColumn: "Pid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Bill_Data__Docto__114A936A",
                table: "Bill_Data");

            migrationBuilder.DropForeignKey(
                name: "FK__Bill_Data__Pid__10566F31",
                table: "Bill_Data");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Bill_Dat__CF6FA49F05935736",
                table: "Bill_Data");

            migrationBuilder.DropColumn(
                name: "Operation_Charges",
                table: "Bill_Data");

            migrationBuilder.DropColumn(
                name: "Room_Charges",
                table: "Bill_Data");

            migrationBuilder.RenameColumn(
                name: "Total_days",
                table: "Bill_Data",
                newName: "Total_Days");

            migrationBuilder.RenameColumn(
                name: "Total_Amount",
                table: "Bill_Data",
                newName: "Total_amount");

            migrationBuilder.RenameColumn(
                name: "Doctor_Id",
                table: "Bill_Data",
                newName: "Doctor_id");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_Data_Doctor_Id",
                table: "Bill_Data",
                newName: "IX_Bill_Data_Doctor_id");

            migrationBuilder.AlterColumn<int>(
                name: "Total_Days",
                table: "Bill_Data",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true,
                oldDefaultValueSql: "((0))");

            migrationBuilder.AlterColumn<int>(
                name: "Total_amount",
                table: "Bill_Data",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(33, 0)",
                oldNullable: true,
                oldComputedColumnSql: "(((([Doctor_Fees]+[Room_Charges]*[Total_days])+[Operation_Charges])+[Medicine_Fees])+[Lab_Fees])");

            migrationBuilder.AlterColumn<string>(
                name: "Patient_Type",
                table: "Bill_Data",
                type: "varchar(1)",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Medicine_Fees",
                table: "Bill_Data",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(18, 0)");

            migrationBuilder.AlterColumn<int>(
                name: "Lab_Fees",
                table: "Bill_Data",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(18, 0)",
                oldNullable: true,
                oldDefaultValueSql: "((0))");

            migrationBuilder.AlterColumn<int>(
                name: "Doctor_Fees",
                table: "Bill_Data",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(18, 0)");

            migrationBuilder.AlterColumn<string>(
                name: "Bill_No",
                table: "Bill_Data",
                type: "varchar(1)",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Operation_Charge",
                table: "Bill_Data",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Room_Charge",
                table: "Bill_Data",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__Bill_Dat__CF6FA49F09167DB9",
                table: "Bill_Data",
                column: "Bill_No");

            migrationBuilder.AddForeignKey(
                name: "FK__Bill_Data__Docto__4CA06362",
                table: "Bill_Data",
                column: "Doctor_id",
                principalTable: "Doctor",
                principalColumn: "Doctor_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Bill_Data__Pid__4BAC3F29",
                table: "Bill_Data",
                column: "Pid",
                principalTable: "Patient",
                principalColumn: "Pid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
