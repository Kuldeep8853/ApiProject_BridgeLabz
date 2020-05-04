using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class GetVahicalDetailsByColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create Procedure GetVahicalDetailsByColor
                                @VahicalColor nvarchar(20)
                                as
                                Begin
                                 Select* from ParkingSpace
                                 where VahicalColore = @VahicalColor
                                  End";
            migrationBuilder.Sql(procedure);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop Procedure GetVahicalDetailsByColor";
            migrationBuilder.Sql(procedure);

        }
    }
}
