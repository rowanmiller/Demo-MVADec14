using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Model;
using System;

namespace CycleSales.Migrations
{
    public partial class LastUpdated : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn("Bike", "LastUpdated", c => c.DateTime(nullable: false, defaultValue: DateTime.Now));
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Bike", "LastUpdated");
        }
    }
}