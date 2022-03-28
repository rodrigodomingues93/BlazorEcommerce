using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "URL" },
                values: new object[,]
                {
                    { 1, "Shoes", "shoes" },
                    { 2, "Consoles", "consoles" },
                    { 3, "Video Games", "video-games" },
                    { 4, "Football Jersey's", "football-jersey" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "The Nike SB Stefan Janoski Max offers good hold and balance courtesy of its skateboarding roots and as designed by Janoski himself. It has adequate room for multiple foot shapes and sizes. This kick is available in men's and women's sizing. It has a textile upper that allows the foot to breathe and stay fresh and cool.", "https://sneakerbardetroit.com/wp-content/uploads/2015/08/Nike-SB-Stefan-Janoski-Max-Suede-University-Red-4.jpg", 69.99m, "Nike SB Stefan Janoski Max" },
                    { 2, 1, "The low-top Adidas I-5923 sneaker is adored by many for its comfortable feel. Its silhouette, which mixes vintage Adidas Originals aesthetic with modern tech, is often described as stylish and cute.", "https://media.endclothing.com/media/catalog/product/0/4/04-07-2018_adidas_i-5923_whitegrey_gum_b37947_mg_1.jpg", 64.99m, "Adidas I-5923" },
                    { 3, 1, "Overview The Old Skool, the Vans classic skate shoe and first to bare the iconic sidestripe, is a low top lace-up featuring sturdy canvas and suede uppers, re-enforced toecaps to withstand repeated wear, padded collars for support and flexibility, and signature rubber waffle outsoles.", "https://photos6.spartoo.pt/photos/261/26185/26185_500_A.jpg", 74.99m, "Vans Old Skool" },
                    { 4, 2, "A slanted black box with both a matte and shine finish, with a sleek blue line through the middle, the PlayStation 4 will slot into most living rooms comfortably. Sony's fourth PlayStation console is fast, sleek and powerful.", "https://gmedia.playstation.com/is/image/SIEPDC/ps4-slim-image-block-01-en-24jul20?$native--t$", 399.99m, "PlayStation 4" },
                    { 5, 2, "Game Boy Color (abbreviated as GBC) is a handheld video game console developed by Nintendo. Originally released in late 1998, it is the successor to the original Game Boy, and is slightly larger than the Game Boy Pocket and significantly smaller than the original Game Boy.", "https://www.backmarket.pt/cdn-cgi/image/format=auto,quality=75,width=640/https://d1eh9yux7w8iql.cloudfront.net/product_images/1568704266.81.jpg", 69.99m, "Game Boy Color" },
                    { 6, 2, "The PlayStation Portable (PSP) is a handheld game console developed and marketed by Sony Computer Entertainment. It was first released in Japan on December 12, 2004, in North America on March 24, 2005, and in PAL regions on September 1, 2005, and is the first handheld installment in the PlayStation line of consoles.", "https://files.tecnoblog.net/wp-content/uploads/2018/10/1200px-Sony-PSP-1000-Body-700x394.jpg", 249.99m, "PlayStation Portable" },
                    { 7, 3, "Pro Evolution Soccer 5 (também conhecido como Winning Eleven 9 no Japão e World Soccer Winning Eleven 9 nos Estados Unidos) é o quinto jogo da série Pro Evolution Soccer. As versões para PlayStation 2 e Xbox foram lançadas em 21 de outubro de 2005 e para PC lançada na semana seguinte, no dia 28 de outubro.", "https://s1.kuantokusta.pt/img_upload/produtos_videojogos/70194_3_pro-evolution-soccer-5-ps2-usado.jpg", 39.90m, "Pro Evolution Soccer 5" },
                    { 8, 3, "Assassin's Creed IV: Black Flag is an action-adventure, stealth game set in an open world environment and played from a third-person perspective. The game features three main cities; Havana, Kingston, and Nassau, which reside under Spanish, British, and pirate influence, respectively.", "https://upload.wikimedia.org/wikipedia/pt/c/ca/Assassins_Creed_4_Black_Flag_capa.png", 69.90m, "Assassin's Creed IV: Black Flag" },
                    { 9, 3, "Grand Theft Auto: San Andreas is an action-adventure game with role-playing and stealth elements. Structured similarly to the previous two games in the series, the core gameplay consists of elements of third-person shooter and driving games, affording the player a large, open-world environment in which to move around.", "https://upload.wikimedia.org/wikipedia/pt/d/d3/Grand_Theft_Auto_San_Andreas_capa.png", 59.90m, "Grand Theft Auto: San Andreas" },
                    { 10, 4, "SportingCP woven crest, Regular fit, Ribbed crewneck, 100% recycled polyester doubleknit, Moisture absorbing, Ribbed cuffs.", "https://cdn-scp.azureedge.net/lojaverdeonline/0002381_camisola-principal-c-pub-2122-regular.jpeg", 89.99m, "Sporting Home Shirt 2021-22" },
                    { 11, 4, "Manchester United woven crest, Regular fit, Ribbed crewneck, 100% recycled polyester doubleknit, Moisture absorbing, Ribbed cuffs.", "https://images.footballfanatics.com/manchester-united/manchester-united-cup-away-shirt-2021-22-with-ronaldo-7-printing_ss4_p-12093065+pv-1+u-8mba4zrbocgqx36ptevj+v-04188d50c2ed430883097f4b79b27a04.jpg?_hv=1&w=900", 60.00m, "Manchester United Away Shirt 2021-22" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
