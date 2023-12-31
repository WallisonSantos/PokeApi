﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Service.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PRODUCT",
                columns: new[] { "PRODUCT_ID", "DESCR_CATEGORY", "DESCR", "LINK_URL_IMAGE", "NAME", "PRICE" },
                values: new object[,]
                {
                    { 2L, "T-shirt", "Utilidades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg?raw=true", "Camiseta No Internet", 69.9m },
                    { 3L, "Action Figure", "Utilidades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true", "Capacete Darth Vader Star Wars Black Series", 999.99m },
                    { 4L, "Action Figure", "Utilidades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true", "Star Wars The Black Series Hasbro - Stormtrooper Imperial", 189.99m },
                    { 5L, "T-shirt", "Utilidades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true", "Camiseta Gamer", 69.99m },
                    { 6L, "T-shirt", "Utilidades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true", "Camiseta SpaceX", 49.99m },
                    { 7L, "T-shirt", "Utilidades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true", "Camiseta Feminina Coffee Benefits", 69.9m },
                    { 8L, "Sweatshirt", "Utilidades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true", "Moletom Com Capuz Cobra Kai", 159.9m },
                    { 9L, "Book", "Utilidades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true", "Livro Star Talk – Neil DeGrasse Tyson", 49.9m },
                    { 10L, "Action Figure", "Utilidades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true", "Star Wars Mission Fleet Han Solo Nave Milennium Falcon", 359.99m },
                    { 11L, "T-shirt", "Utilidades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true", "Camiseta Elon Musk Spacex Marte Occupy Mars", 59.99m },
                    { 12L, "T-shirt", "Utilidades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true", "Camiseta GNU Linux Programador Masculina", 59.99m },
                    { 13L, "T-shirt", "Utilidades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg", "Camiseta Goku Fases", 59.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 13L);
        }
    }
}
