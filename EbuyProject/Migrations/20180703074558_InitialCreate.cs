using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EbuyProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false),
                    AuthorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Bogos",
                columns: table => new
                {
                    BogoId = table.Column<int>(nullable: false),
                    BogoLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bogos", x => x.BogoId);
                });

            migrationBuilder.CreateTable(
                name: "CasualCustomers",
                columns: table => new
                {
                    CasualId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FirstPurchase = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CasualCustomers", x => x.CasualId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false),
                    CategoryType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "CreditCardTypes",
                columns: table => new
                {
                    CardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(nullable: false),
                    Prefix = table.Column<int>(nullable: false),
                    NumOfDigit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCardTypes", x => x.CardId);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryModes",
                columns: table => new
                {
                    ModeId = table.Column<int>(nullable: false),
                    Mode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryModes", x => x.ModeId);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    ClubMemberDiscounts = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.ClubMemberDiscounts);
                });

            migrationBuilder.CreateTable(
                name: "Personnels",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoginName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnels", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ShipmenDetails",
                columns: table => new
                {
                    ShipmenDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Buyer = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    Street = table.Column<string>(nullable: true),
                    HouseNumber = table.Column<int>(nullable: false),
                    Pob = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmenDetails", x => x.ShipmenDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentAreas",
                columns: table => new
                {
                    ShipmentAreaId = table.Column<int>(nullable: false),
                    Area = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentAreas", x => x.ShipmentAreaId);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentCompanies",
                columns: table => new
                {
                    ShipmentCompanyId = table.Column<int>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentCompanies", x => x.ShipmentCompanyId);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentOptions",
                columns: table => new
                {
                    ShipmentOptionId = table.Column<int>(nullable: false),
                    ShipmentOption = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentOptions", x => x.ShipmentOptionId);
                });

            migrationBuilder.CreateTable(
                name: "Vat",
                columns: table => new
                {
                    VAT = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vat", x => x.VAT);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    PublicationDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ProductAbstract = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    BogoId = table.Column<int>(nullable: true),
                    AuthorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Bogos_BogoId",
                        column: x => x.BogoId,
                        principalTable: "Bogos",
                        principalColumn: "BogoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CountryAreas",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(nullable: true),
                    ShipmentAreaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryAreas", x => x.CountryId);
                    table.ForeignKey(
                        name: "FK_CountryAreas_ShipmentAreas_ShipmentAreaId",
                        column: x => x.ShipmentAreaId,
                        principalTable: "ShipmentAreas",
                        principalColumn: "ShipmentAreaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentPrices",
                columns: table => new
                {
                    ShipmentPriceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BasicCharge = table.Column<double>(nullable: false),
                    ItemCharge = table.Column<double>(nullable: false),
                    ShipmentDuration = table.Column<int>(nullable: false),
                    ShipmentAreaId = table.Column<int>(nullable: true),
                    ShipmentOptionId = table.Column<int>(nullable: true),
                    ShipmentCompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentPrices", x => x.ShipmentPriceId);
                    table.ForeignKey(
                        name: "FK_ShipmentPrices_ShipmentAreas_ShipmentAreaId",
                        column: x => x.ShipmentAreaId,
                        principalTable: "ShipmentAreas",
                        principalColumn: "ShipmentAreaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShipmentPrices_ShipmentCompanies_ShipmentCompanyId",
                        column: x => x.ShipmentCompanyId,
                        principalTable: "ShipmentCompanies",
                        principalColumn: "ShipmentCompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShipmentPrices_ShipmentOptions_ShipmentOptionId",
                        column: x => x.ShipmentOptionId,
                        principalTable: "ShipmentOptions",
                        principalColumn: "ShipmentOptionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreditCardNumber = table.Column<int>(nullable: false),
                    ModeId = table.Column<int>(nullable: true),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    ShipmentCost = table.Column<double>(nullable: false),
                    CardExpire = table.Column<string>(nullable: true),
                    CardOwner = table.Column<string>(nullable: true),
                    TotalCost = table.Column<double>(nullable: false),
                    ShipmentDetailsId = table.Column<int>(nullable: true),
                    ShipmentOptionId = table.Column<int>(nullable: true),
                    CardId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_Transactions_CreditCardTypes_CardId",
                        column: x => x.CardId,
                        principalTable: "CreditCardTypes",
                        principalColumn: "CardId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_DeliveryModes_ModeId",
                        column: x => x.ModeId,
                        principalTable: "DeliveryModes",
                        principalColumn: "ModeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_ShipmenDetails_ShipmentDetailsId",
                        column: x => x.ShipmentDetailsId,
                        principalTable: "ShipmenDetails",
                        principalColumn: "ShipmenDetailsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_ShipmentOptions_ShipmentOptionId",
                        column: x => x.ShipmentOptionId,
                        principalTable: "ShipmentOptions",
                        principalColumn: "ShipmentOptionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClubMembers",
                columns: table => new
                {
                    MemberId = table.Column<int>(nullable: false),
                    LoginName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    HouseNumber = table.Column<int>(nullable: false),
                    Street = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    FirstRegistration = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubMembers", x => x.MemberId);
                    table.ForeignKey(
                        name: "FK_ClubMembers_CountryAreas_CountryId",
                        column: x => x.CountryId,
                        principalTable: "CountryAreas",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchasedProducts",
                columns: table => new
                {
                    PurchaseProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PurchasedDate = table.Column<DateTime>(nullable: false),
                    PurchaseBasicCost = table.Column<double>(nullable: false),
                    Vat = table.Column<double>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    TransactionId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasedProducts", x => x.PurchaseProductId);
                    table.ForeignKey(
                        name: "FK_PurchasedProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchasedProducts_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "TransactionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClubMembers_CountryId",
                table: "ClubMembers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryAreas_ShipmentAreaId",
                table: "CountryAreas",
                column: "ShipmentAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AuthorId",
                table: "Products",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BogoId",
                table: "Products",
                column: "BogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedProducts_ProductId",
                table: "PurchasedProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedProducts_TransactionId",
                table: "PurchasedProducts",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentPrices_ShipmentAreaId",
                table: "ShipmentPrices",
                column: "ShipmentAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentPrices_ShipmentCompanyId",
                table: "ShipmentPrices",
                column: "ShipmentCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentPrices_ShipmentOptionId",
                table: "ShipmentPrices",
                column: "ShipmentOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CardId",
                table: "Transactions",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ModeId",
                table: "Transactions",
                column: "ModeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ShipmentDetailsId",
                table: "Transactions",
                column: "ShipmentDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ShipmentOptionId",
                table: "Transactions",
                column: "ShipmentOptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CasualCustomers");

            migrationBuilder.DropTable(
                name: "ClubMembers");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Personnels");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "PurchasedProducts");

            migrationBuilder.DropTable(
                name: "ShipmentPrices");

            migrationBuilder.DropTable(
                name: "Vat");

            migrationBuilder.DropTable(
                name: "CountryAreas");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "ShipmentCompanies");

            migrationBuilder.DropTable(
                name: "ShipmentAreas");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Bogos");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CreditCardTypes");

            migrationBuilder.DropTable(
                name: "DeliveryModes");

            migrationBuilder.DropTable(
                name: "ShipmenDetails");

            migrationBuilder.DropTable(
                name: "ShipmentOptions");
        }
    }
}
