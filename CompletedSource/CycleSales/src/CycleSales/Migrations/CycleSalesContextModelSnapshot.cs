using CycleSales.Models;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using System;

namespace CycleSales.Migrations
{
    [ContextType(typeof(CycleSales.Models.CycleSalesContext))]
    public class CycleSalesContextModelSnapshot : ModelSnapshot
    {
        public override IModel Model
        {
            get
            {
                var builder = new BasicModelBuilder();
                
                builder.Entity("CycleSales.Models.Bike", b =>
                    {
                        b.Property<int>("BikeId")
                            .GenerateValueOnAdd();
                        b.Property<string>("Description");
                        b.Property<string>("Features");
                        b.Property<string>("ImageUrl");
                        b.Property<DateTime>("LastUpdated");
                        b.Property<string>("ModelNo");
                        b.Property<string>("Name");
                        b.Property<decimal>("Retail");
                        b.Key("BikeId");
                    });
                
                return builder.Model;
            }
        }
    }
}