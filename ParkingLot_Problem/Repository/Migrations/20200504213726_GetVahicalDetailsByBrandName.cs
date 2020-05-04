using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class GetVahicalDetailsByBrandName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create Procedure GetVahicalDetailsByBrandName
                                @VahicalColor nvarchar(20)
                                as
                                Begin
                                 Select* from ParkingSpace
                                 where VehicalBrand = @VahicalColor
                                  End";
            migrationBuilder.Sql(procedure);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop Procedure GetVahicalDetailsByBrandName";
            migrationBuilder.Sql(procedure);

        }
    }
}
