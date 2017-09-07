using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MatterCentral.Migrations
{
    public partial class MatterModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ShowOnAuthorization = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorizationStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizationStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemStatus = table.Column<bool>(type: "bit", nullable: false),
                    OrganizationalUnit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MaxGrossReceive = table.Column<int>(type: "int", nullable: false),
                    MaxGrossShip = table.Column<int>(type: "int", nullable: false),
                    MaxTareReceive = table.Column<int>(type: "int", nullable: false),
                    MaxTareShip = table.Column<int>(type: "int", nullable: false),
                    MinGrossReceive = table.Column<int>(type: "int", nullable: false),
                    MinGrossShip = table.Column<int>(type: "int", nullable: false),
                    MinTareReceive = table.Column<int>(type: "int", nullable: false),
                    MinTareShip = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemStatus = table.Column<bool>(type: "bit", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketApprovalStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketApprovalStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketProcessStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketProcessStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transportations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountCode = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemStatus = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeightUnitTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightUnitTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_AccountTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AccountTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Scalers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scalers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scalers_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearPlanted = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracts_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Authorizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    Buyer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Effective = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiverId = table.Column<int>(type: "int", nullable: true),
                    ShipperId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authorizations_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Authorizations_Organizations_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Authorizations_Organizations_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Authorizations_AuthorizationStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AuthorizationStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OffloadPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TractId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OffloadPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OffloadPoints_Tracts_TractId",
                        column: x => x.TractId,
                        principalTable: "Tracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Commodities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthorizationId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescId = table.Column<int>(type: "int", nullable: false),
                    DescName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubGroupId = table.Column<int>(type: "int", nullable: false),
                    SubGroupName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commodities_Authorizations_AuthorizationId",
                        column: x => x.AuthorizationId,
                        principalTable: "Authorizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    ApprovalStatusId = table.Column<int>(type: "int", nullable: true),
                    AuthorizationId = table.Column<int>(type: "int", nullable: true),
                    CommodityId = table.Column<int>(type: "int", nullable: true),
                    ContainerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConvertedNet = table.Column<double>(type: "float", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: true),
                    DriverId = table.Column<int>(type: "int", nullable: true),
                    Gross = table.Column<double>(type: "float", nullable: false),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoadTicketNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Net = table.Column<double>(type: "float", nullable: false),
                    OffloadPointId = table.Column<int>(type: "int", nullable: true),
                    OriginationId = table.Column<int>(type: "int", nullable: true),
                    OutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProcessStatusId = table.Column<int>(type: "int", nullable: true),
                    ProducerId = table.Column<int>(type: "int", nullable: true),
                    QuotaOverride = table.Column<bool>(type: "bit", nullable: false),
                    ScalerId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    SupplierTicketNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tare = table.Column<double>(type: "float", nullable: false),
                    TractId = table.Column<int>(type: "int", nullable: true),
                    TransportationId = table.Column<int>(type: "int", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    WeightUnitTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_TicketApprovalStatuses_ApprovalStatusId",
                        column: x => x.ApprovalStatusId,
                        principalTable: "TicketApprovalStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Authorizations_AuthorizationId",
                        column: x => x.AuthorizationId,
                        principalTable: "Authorizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Commodities_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Locations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_OffloadPoints_OffloadPointId",
                        column: x => x.OffloadPointId,
                        principalTable: "OffloadPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Locations_OriginationId",
                        column: x => x.OriginationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_TicketProcessStatuses_ProcessStatusId",
                        column: x => x.ProcessStatusId,
                        principalTable: "TicketProcessStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Organizations_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Scalers_ScalerId",
                        column: x => x.ScalerId,
                        principalTable: "Scalers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_TicketStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "TicketStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Tracts_TractId",
                        column: x => x.TractId,
                        principalTable: "Tracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Transportations_TransportationId",
                        column: x => x.TransportationId,
                        principalTable: "Transportations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_TicketTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TicketTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_WeightUnitTypes_WeightUnitTypeId",
                        column: x => x.WeightUnitTypeId,
                        principalTable: "WeightUnitTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_TypeId",
                table: "Accounts",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Authorizations_AccountId",
                table: "Authorizations",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Authorizations_ReceiverId",
                table: "Authorizations",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Authorizations_ShipperId",
                table: "Authorizations",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_Authorizations_StatusId",
                table: "Authorizations",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodities_AuthorizationId",
                table: "Commodities",
                column: "AuthorizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OffloadPoints_TractId",
                table: "OffloadPoints",
                column: "TractId");

            migrationBuilder.CreateIndex(
                name: "IX_Scalers_LocationId",
                table: "Scalers",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_AccountId",
                table: "Tickets",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ApprovalStatusId",
                table: "Tickets",
                column: "ApprovalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_AuthorizationId",
                table: "Tickets",
                column: "AuthorizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CommodityId",
                table: "Tickets",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_DestinationId",
                table: "Tickets",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_DriverId",
                table: "Tickets",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_OffloadPointId",
                table: "Tickets",
                column: "OffloadPointId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_OriginationId",
                table: "Tickets",
                column: "OriginationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProcessStatusId",
                table: "Tickets",
                column: "ProcessStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProducerId",
                table: "Tickets",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ScalerId",
                table: "Tickets",
                column: "ScalerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StatusId",
                table: "Tickets",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TractId",
                table: "Tickets",
                column: "TractId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TransportationId",
                table: "Tickets",
                column: "TransportationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TypeId",
                table: "Tickets",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_WeightUnitTypeId",
                table: "Tickets",
                column: "WeightUnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracts_LocationId",
                table: "Tracts",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buyers");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "TicketApprovalStatuses");

            migrationBuilder.DropTable(
                name: "Commodities");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "OffloadPoints");

            migrationBuilder.DropTable(
                name: "TicketProcessStatuses");

            migrationBuilder.DropTable(
                name: "Scalers");

            migrationBuilder.DropTable(
                name: "TicketStatuses");

            migrationBuilder.DropTable(
                name: "Transportations");

            migrationBuilder.DropTable(
                name: "TicketTypes");

            migrationBuilder.DropTable(
                name: "WeightUnitTypes");

            migrationBuilder.DropTable(
                name: "Authorizations");

            migrationBuilder.DropTable(
                name: "Tracts");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "AuthorizationStatus");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "AccountTypes");
        }
    }
}
