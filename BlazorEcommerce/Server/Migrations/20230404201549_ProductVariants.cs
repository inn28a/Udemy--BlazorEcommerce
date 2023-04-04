using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductVariants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Default" },
                    { 2, "Witchcraft" },
                    { 3, "Demons" },
                    { 4, "Mixtures" },
                    { 5, "JapanManga" },
                    { 6, "Comic-book" },
                    { 7, "Comic-set" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "This is a science fiction manga by Japanese artist Hiroki Endo, published monthly in the Japanese magazine Monthly Afternoon. It is published in the United States by Dark Horse Comics, in the United Kingdom by Titan Books, and in Germany by Egmont Manga & Anime. Eden is set in the near future, following a pandemic called closure virus which killed 15 percent of the world's population, crippled or disfigured many more, and upset the world's political balance greatly. Eden is to some extent based on Gnostic mythology, with some characters, such as Ennoia, being named after Gnostic entities, and other Gnostic influences being seen in the themes of the ongoing story.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Also known as the Sub-Mariner, is a character appearing in American comic books published by Marvel Comics. Debuting in early 1939, the character was created by writer-artist Bill Everett for comic book packager Funnies Inc. Initially created for the unreleased comic Motion Picture Funnies Weekly, the character first appeared publicly in Marvel Comics #1 (cover-dated Oct. 1939), which was the first comic book from Timely Comics, the 1930s–1940s predecessor of Marvel Comics. During that period, known to historians and fans as the Golden Age of Comic Books, the Sub-Mariner was one of Timely's top three characters, along with Captain America and the original Human Torch. Moreover, Namor has also been described as the first comic book antihero.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Is an ongoing comic book series featuring the Marvel Comics superhero the Hulk and his alter ego Dr. Bruce Banner. First published in May 1962, the series ran for six issues before it was cancelled in March 1963, and the Hulk character began appearing in Tales to Astonish. With issue #102, Tales to Astonish was renamed to The Incredible Hulk in April 1968, becoming its second volume.");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 17, 1, "This is an archaeological study of the material evidence for ritual and magical practices in Europe, containing a particular emphasis on London and South East England. It was written by the English archaeologist Ralph Merrifield, the former deputy director of the Museum of London, and first published by B.T. Batsford in 1987", "https://upload.wikimedia.org/wikipedia/en/8/8f/Archaeology_of_Ritual_and_Magic.jpg", "The Archaeology of Ritual and Magic" },
                    { 18, 1, "This is a 2004 book by Italian-American intellectual Silvia Federici. Responding to both feminist and Marxist traditions, the book offers a critical alternative to Karl Marx's theory of primitive accumulation.", "https://upload.wikimedia.org/wikipedia/en/2/2e/Caliban_and_the_Witch.jpg", "Caliban and the Witch: Women, the Body and Primitive Accumulation" },
                    { 19, 1, "This is a book by Jules Michelet on the history of witchcraft. Originally published in Paris as La Sorcière in 1862, the first English translation appeared in London a year later.", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Martin_van_Maele_-_La_Sorci%C3%A8re_06.jpg/800px-Martin_van_Maele_-_La_Sorci%C3%A8re_06.jpg", "Satanism and Witchcraft" },
                    { 20, 1, "This is the debut young adult novel co-written by American entertainer Hilary Duff with Elise Allen. It was available at booksellers on October 12, 2010. It is the first in a series of books that Duff became committed to write. Elise Allen collaborated on the first book with Duff, and became committed to work jointly with her on the others. The book is now a New York Times Best Seller.", "https://upload.wikimedia.org/wikipedia/en/1/16/Elixir.jpg", "Elixir" },
                    { 21, 1, "This  is a 1815 novel by E. T. A. Hoffmann.The basic idea for the story was adopted from Matthew Gregory Lewis's novel The Monk, which is itself mentioned in the text.", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/E.T.A.Hoffmann_%281815%29.JPG/1024px-E.T.A.Hoffmann_%281815%29.JPG", "The Devil's Elixirs" },
                    { 22, 3, "This is a 1974 collection of Marvel Comics comic book stories, selected and introduced by Marvel writer and editor Stan Lee. The book was published by Fireside Books, an imprint of Simon & Schuster, and was Marvel's first trade paperback collection", "https://upload.wikimedia.org/wikipedia/en/a/ab/Origins_of_Marvel_Comics.jpg", "Origins of Marvel Comics" },
                    { 23, 3, "This is the eighth collection of issues in the DC Comics series The Sandman. It was written by Neil Gaiman; illustrated by Michael Allred, Gary Amaro, Mark Buckingham, Dick Giordano, Tony Harris, Steve Leialoha, Vince Locke, Shea Anton Pensa, Alec Stevens, Bryan Talbot, John Watkiss, and Michael Zulli; colored by Danny Vozzo; and lettered by Todd Klein. The stories in the collection first appeared in 1993. The collection first appeared in paperback and hardback editions in 1994 with an introduction by Stephen King. The collection's title, setting, and a number of its themes and images are also found in G.K.", "https://upload.wikimedia.org/wikipedia/en/3/37/Worlds_End_%28cover%29.jpg", "Worlds' End" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 2, 19.99m, 9.99m },
                    { 2, 2, 0m, 9.99m },
                    { 3, 2, 21.99m, 10.99m },
                    { 4, 2, 28.99m, 14.99m },
                    { 5, 2, 0m, 26.99m },
                    { 6, 3, 0m, 6.99m },
                    { 7, 2, 0m, 14.99m },
                    { 8, 5, 0m, 36.99m },
                    { 9, 5, 0m, 27.99m },
                    { 10, 5, 0m, 12.99m },
                    { 11, 5, 71.99m, 66.99m },
                    { 12, 6, 51.99m, 46.99m },
                    { 13, 6, 0m, 16.99m },
                    { 14, 6, 21.99m, 5.99m },
                    { 15, 6, 51.99m, 36.99m },
                    { 16, 7, 0m, 6.99m },
                    { 17, 4, 21.99m, 10.99m },
                    { 18, 3, 39.99m, 21.99m },
                    { 19, 3, 44.99m, 26.99m },
                    { 20, 4, 29.99m, 16.99m },
                    { 21, 4, 0m, 22.99m },
                    { 22, 7, 0m, 36.99m },
                    { 23, 7, 21.99m, 6.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 9.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 7.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 4.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 8.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 10.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 6.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 12.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 3.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 3.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 3.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Price" },
                values: new object[] { " is a science fiction manga by Japanese artist Hiroki Endo, published monthly in the Japanese magazine Monthly Afternoon. It is published in the United States by Dark Horse Comics, in the United Kingdom by Titan Books, and in Germany by Egmont Manga & Anime. Eden is set in the near future, following a pandemic called closure virus which killed 15 percent of the world's population, crippled or disfigured many more, and upset the world's political balance greatly. Eden is to some extent based on Gnostic mythology, with some characters, such as Ennoia, being named after Gnostic entities, and other Gnostic influences being seen in the themes of the ongoing story.", 3.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 4.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 4.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 4.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Price" },
                values: new object[] { " also known as the Sub-Mariner, is a character appearing in American comic books published by Marvel Comics. Debuting in early 1939, the character was created by writer-artist Bill Everett for comic book packager Funnies Inc. Initially created for the unreleased comic Motion Picture Funnies Weekly, the character first appeared publicly in Marvel Comics #1 (cover-dated Oct. 1939), which was the first comic book from Timely Comics, the 1930s–1940s predecessor of Marvel Comics. During that period, known to historians and fans as the Golden Age of Comic Books, the Sub-Mariner was one of Timely's top three characters, along with Captain America and the original Human Torch. Moreover, Namor has also been described as the first comic book antihero.", 4.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Price" },
                values: new object[] { "is an ongoing comic book series featuring the Marvel Comics superhero the Hulk and his alter ego Dr. Bruce Banner. First published in May 1962, the series ran for six issues before it was cancelled in March 1963, and the Hulk character began appearing in Tales to Astonish. With issue #102, Tales to Astonish was renamed to The Incredible Hulk in April 1968, becoming its second volume.", 4.99m });
        }
    }
}
