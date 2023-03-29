using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "A Perspective on Witches and Seers in the Early Modern Age is a study of the beliefs regarding witchcraft and magic in Early Modern Hungary written by the Hungarian historian Éva Pócs. The study was first published in Hungarian in 1997 as Élők és holtak, látók és boszorkányok by Akadémiai Kiadó. In 1999, it was later translated into English by Szilvia Rédey and Michael Webb and published by the Central European University Press.", "https://upload.wikimedia.org/wikipedia/en/c/c6/Between_the_Living_and_the_Dead.jpg", 9.99m, "Between the Living and the Dead" },
                    { 2, "Witchcraft and Magic in Enlightenment Europe is an edited volume edited by the historians Owen Davies and Willem de Blécourt. It was first published by Manchester University Press in 2004. It consists of ten essays on the continued practice of magic and the belief in witchcraft in Europe during the European Enlightenment after the end of the witch trials in the early modern period. It was accompanied by Witchcraft Continued: Popular Magic in Modern Europe, dealing with the nineteenth and twentieth centuries, also published by Manchester University Press in 2004", "https://upload.wikimedia.org/wikipedia/en/b/b5/Beyond_the_witch_trials.jpg", 7.99m, "Beyond the Witch Trials" },
                    { 3, "Concerning the Boundary between Wilderness and Civilization is an anthropological and philosophical study of the altered states of consciousness found in shamanism and European witchcraft written by German anthropologist Hans Peter Duerr. First published in 1978 by Syndikat Autoren-und Verlagsgesellschaft under the German title of Traumzeit: Über die Grenze zwischen Wildnis und Zivilisation, it was translated into English by the Hungarian-American anthropologist Felicitas Goodman and published by Basil Blackwell in 1985.", "https://upload.wikimedia.org/wikipedia/en/c/c5/Dreamtime%2C_German_version.jpg", 4.99m, "Dreamtime" },
                    { 4, "The Rise of Wicca and Paganism in America is a historical study of Wicca and Contemporary Paganism in the United States. It was written by the American academic Chas S. Clifton of Colorado State University-Pueblo, and published by AltaMira Press in 2005.", "https://upload.wikimedia.org/wikipedia/en/a/a5/Her_Hidden_Children.jpg", 8.99m, "Her Hidden Children" },
                    { 5, "Witchcraft and Agrarian Cults in the Sixteenth and Seventeenth Centuries is a historical study of the benandanti folk custom of 16th and 17th century Friuli, Northeastern Italy. It was written by the Italian historian Carlo Ginzburg, then of the University of Bologna, and first published by the company Giulio Einaudi in 1966 under the Italian title of I Benandanti: Stregoneria e culti agrari tra Cinquecento e Seicento. It was later translated into English by John and Anne Tedeschi and published by Routledge and Kegan Paul in 1983 with a new foreword written by the historian Eric Hobsbawm.", "https://upload.wikimedia.org/wikipedia/en/4/44/The_Night_Battles.png", 10.99m, "The Night Battles" },
                    { 6, "An Enquiry Inspired by the Great Witch-Hunt is a historical study of the beliefs regarding European witchcraft in Late Medieval and Early Modern Europe, with particular reference to the development of the witches' sabbat and its influence on the witch trials in the Early Modern period. It was written by the English historian Norman Cohn, then of the University of Sussex, and first published by Sussex University Press in association with Heinemann Educational Books in 1975. It was released as a part of a series of academic books entitled 'Studies in the Dynamics of Persecution and Extermination' that were funded by the Columbus Centre and edited by Cohn himself.", "https://upload.wikimedia.org/wikipedia/en/8/8c/Europe%27s_Inner_Demons.jpg", 6.99m, "Europe's Inner Demons" },
                    { 7, "Chonrad Stoeckhlin and the Phantoms of the Night is a study of the arrest and trial of Chonrad Stoecklin (1549–1587), a German herdsman from the town of Oberstdorf who was accused and executed for the crime of witchcraft after experiencing a series of visions. Written by the German historian Wolfgang Behringer, himself a specialist in the Early Modern witch trials of Germany, Shaman of Oberstdorf was initially published in German as Chonrad Stoekhlin und die Nachtschar: Eine Geschichte aus der frühen Neuzeit by R. Piper GmbH & Co. in 1994. It was subsequently translated into English by H.C. Erik Midelfort and published in 1998 by the University of Virginia Press.", "https://upload.wikimedia.org/wikipedia/en/0/08/Shaman_of_Oberstdorf.jpg", 12.99m, "Shaman of Oberstdorf" },
                    { 8, "Is a Japanese manga series written by Tsugumi Ohba and illustrated by Takeshi Obata. It was serialized in Shueisha's shōnen manga magazine Weekly Shōnen Jump from December 2003 to May 2006, with its 108 chapters collected in 12 tankōbon volumes. ", "https://upload.wikimedia.org/wikipedia/en/6/6f/Death_Note_Vol_1.jpg", 3.99m, "Death Note Episode 1" },
                    { 9, "Is a Japanese manga series written by Tsugumi Ohba and illustrated by Takeshi Obata. It was serialized in Shueisha's shōnen manga magazine Weekly Shōnen Jump from December 2003 to May 2006, with its 108 chapters collected in 12 tankōbon volumes. ", "https://upload.wikimedia.org/wikipedia/en/3/31/Death_Note_2_The_Last_Name_poster.jpeg", 3.99m, "Death Note Episode 2" },
                    { 10, "is a Japanese manga series written and illustrated by the duo So-ma-to (specifically, written and designed by Nori and illustrated by Hisshi).It has been serialized in Shueisha's seinen manga magazine Weekly Young Jump since September 2018, with the chapters collected in twelve tankōbon volumes as of October 2022. An anime television series adaptation by CloverWorks aired from April to July 2021. A second season aired from July to September 2022.", "https://upload.wikimedia.org/wikipedia/en/4/4a/Shadows_House_volume_1_cover.jpg", 3.99m, "Shadows House" },
                    { 11, " is a science fiction manga by Japanese artist Hiroki Endo, published monthly in the Japanese magazine Monthly Afternoon. It is published in the United States by Dark Horse Comics, in the United Kingdom by Titan Books, and in Germany by Egmont Manga & Anime. Eden is set in the near future, following a pandemic called closure virus which killed 15 percent of the world's population, crippled or disfigured many more, and upset the world's political balance greatly. Eden is to some extent based on Gnostic mythology, with some characters, such as Ennoia, being named after Gnostic entities, and other Gnostic influences being seen in the themes of the ongoing story.", "https://upload.wikimedia.org/wikipedia/en/9/9e/Edencover_07.jpg", 3.99m, "Eden: It's an Endless World!" },
                    { 12, "Name of an American comic book anthology series and two one-shot comics published by Marvel Comics. The first, which ran from 1959 to 1968, began as a science-fiction anthology that served as a showcase for such artists as Jack Kirby, Steve Ditko, and Don Heck, then featured superheroes Captain America and Iron Man during the Silver Age of Comic Books before changing its title to Captain America with issue #100 (cover-dated April 1968). ", "https://upload.wikimedia.org/wikipedia/en/8/85/TalesOfSuspense1.jpg", 4.99m, "Tales of Suspense" },
                    { 13, "Iron Man is a superhero appearing in American comic books published by Marvel Comics. The character was co-created by writer and editor Stan Lee, developed by scripter Larry Lieber, and designed by artists Don Heck and Jack Kirby. The character made his first appearance in Tales of Suspense #39 (cover dated March 1963), and received his own title in Iron Man #1 (May 1968). In 1963, the character founded the Avengers superhero team with Thor, Ant-Man, Wasp and the Hulk.", "https://upload.wikimedia.org/wikipedia/en/4/47/Iron_Man_%28circa_2018%29.png", 4.99m, "Iron Man" },
                    { 14, "The primary title bearing that name was published from January 1959 to March 1968. It began as a science-fiction anthology that served as a showcase for such artists as Jack Kirby and Steve Ditko, then featured superheroes during the period fans and historians call the Silver Age of Comic Books. It became The Incredible Hulk with issue No. 102 (April 1968). Its sister title was Tales of Suspense.", "https://upload.wikimedia.org/wikipedia/en/7/72/Tales_astonish_001.jpg", 4.99m, "Tales to Astonish" },
                    { 15, " also known as the Sub-Mariner, is a character appearing in American comic books published by Marvel Comics. Debuting in early 1939, the character was created by writer-artist Bill Everett for comic book packager Funnies Inc. Initially created for the unreleased comic Motion Picture Funnies Weekly, the character first appeared publicly in Marvel Comics #1 (cover-dated Oct. 1939), which was the first comic book from Timely Comics, the 1930s–1940s predecessor of Marvel Comics. During that period, known to historians and fans as the Golden Age of Comic Books, the Sub-Mariner was one of Timely's top three characters, along with Captain America and the original Human Torch. Moreover, Namor has also been described as the first comic book antihero.", "https://upload.wikimedia.org/wikipedia/en/f/f7/NAMOR1cover-CMYKcrop.jpg", 4.99m, "Namor" },
                    { 16, "is an ongoing comic book series featuring the Marvel Comics superhero the Hulk and his alter ego Dr. Bruce Banner. First published in May 1962, the series ran for six issues before it was cancelled in March 1963, and the Hulk character began appearing in Tales to Astonish. With issue #102, Tales to Astonish was renamed to The Incredible Hulk in April 1968, becoming its second volume.", "https://upload.wikimedia.org/wikipedia/en/0/0f/Hulk1.jpg", 4.99m, "The Incredible Hulk" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
