using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Model;
using System;

namespace CycleSales.Migrations
{
    public partial class Features : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn("Bike", "Features", c => c.String());
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Bike", "Features");
        }
    }
}