using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Model;
using System;

namespace CycleSales.Migrations
{
    public partial class BikeTable : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable("Bike",
                c => new
                    {
                        BikeId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        ModelNo = c.String(),
                        Name = c.String(),
                        Retail = c.Decimal(nullable: false)
                    })
                .PrimaryKey("PK_Bike", t => t.BikeId);
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Bike");
        }
    }
}