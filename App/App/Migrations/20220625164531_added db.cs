using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class addeddb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Introducing Galaxy S22; The First Smartphone To Feature Corning® Gorilla® Glass Victus®+ Nightography Camera, Storage To Hold All Your Night Shots ", "https://images.pexels.com/photos/11772525/pexels-photo-11772525.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Samsung s 22", 850 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 2, "The HUAWEI Mate 30 Pro features the Kirin 990 chipset and new EMUI10 for enhanced speed and performance.", "https://fscl01.fonpit.de/userfiles/7043987/image/Huawei-Mate-30-Pro/AndroidPIT-huawei-mate-30-pro-mai_n-camera.jpg", "Huawei Mate 30 pro", 750 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, "Men Ripped Washed Denim Jacket", "https://img.ltwebstatic.com/images3_pi/2021/12/17/1639709464654c7e2ed215d07ed68c62c719249af2_thumbnail_900x.webp", "Jacket", 30 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 2, "Huge camera upgrades. New OLED display with ProMotion. Fastest smartphone chip ever. Breakthrough battery life.", "https://images.pexels.com/photos/9867096/pexels-photo-9867096.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Iphone 13", 1000 },
                    { 5, 1, "Men Ripped Frayed Skinny Jeans", "https://img.ltwebstatic.com/images3_pi/2021/11/01/1635759829f30e9606b61a22b3c8b9b314d6425fb6_thumbnail_900x.webp", "Jeans", 15 },
                    { 6, 1, "Men Button Front Solid Shirt", "https://img.ltwebstatic.com/images3_pi/2022/03/21/164785138330ce413b577106f77813e7b87489d507_thumbnail_900x.webp", "Shirt", 750 },
                    { 7, 3, "SHEGLAM Wing It Waterproof Liner Duo - Black", "https://img.ltwebstatic.com/images3_pi/2020/11/04/160448388566cbde6e32739ed3613a2039882cd1ce_thumbnail_900x.webp", "Eyeliner", 5 },
                    { 8, 3, "SHEGLAM Smart Cookie Palette", "https://img.ltwebstatic.com/images3_pi/2022/03/16/16474155697760b39c9ccd0cfbc395963be1a0605f_thumbnail_900x.webp", "Eyeshadow", 10 },
                    { 9, 3, " Long Lasting Breathable Matte Foundation-Fair", "https://img.ltwebstatic.com/images3_pi/2022/03/16/1647408191a4e2d4e9b275a0439d296b96389b68ea_thumbnail_900x.webp", "Foundation", 15 }
                });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImgUrl", "Name" },
                values: new object[] { "https://images.pexels.com/photos/2872879/pexels-photo-2872879.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Clothes" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImgUrl", "Name" },
                values: new object[] { "https://images.pexels.com/photos/207589/pexels-photo-207589.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Mobiles" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImgUrl", "Name" },
                values: new object[] { "https://images.pexels.com/photos/2253834/pexels-photo-2253834.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Beauty" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Test 2", null, "Toy", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 3, "Test 3", null, "Tshirt", 10 });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImgUrl", "Name" },
                values: new object[] { null, "Beauty" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImgUrl", "Name" },
                values: new object[] { "https://images.pexels.com/photos/2872879/pexels-photo-2872879.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Clothes" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImgUrl", "Name" },
                values: new object[] { "https://images.pexels.com/photos/207589/pexels-photo-207589.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Mobiles" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { 4, "https://images.pexels.com/photos/2253834/pexels-photo-2253834.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Computers & accessories" },
                    { 5, null, "TV & Home Entertainment" },
                    { 6, null, "Furniture" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 4, "Test 4", null, "Shoes", 20 });
        }
    }
}
