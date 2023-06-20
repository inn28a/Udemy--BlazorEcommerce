

using static System.Net.WebRequestMethods;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>().HasKey(p => new {p.ProductId, p.ProductTypeId});
            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1, Name = "Default"},
                new ProductType { Id = 2, Name = "Witchcraft"},
                new ProductType { Id = 3, Name = "Demons"},
                new ProductType { Id = 4, Name = "Mixtures"},
                new ProductType { Id = 5, Name = "JapanManga"},
                new ProductType { Id = 6, Name = "Comic-book"},
                new ProductType { Id = 7, Name = "Comic-set"}        
                  ); 

            modelBuilder.Entity<Category>().HasData(

                new Category
                {
                    Id = 1,
                    Name = "Witch Craft",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Manga",
                    Url = "manga"
                },
                new Category
                {
                    Id = 3,
                    Name = "Comic books",
                    Url = "comic"
                }
                );

            modelBuilder.Entity<Product>().HasData(

           new Product
           {
               Id = 1,
               Title = "Between the Living and the Dead",
               Description = "A Perspective on Witches and Seers in the Early Modern Age is a study of the beliefs regarding witchcraft and magic in Early Modern Hungary written by the Hungarian historian Éva Pócs. The study was first published in Hungarian in 1997 as Élők és holtak, látók és boszorkányok by Akadémiai Kiadó. In 1999, it was later translated into English by Szilvia Rédey and Michael Webb and published by the Central European University Press.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c6/Between_the_Living_and_the_Dead.jpg",
               
               CategoryId = 1 

           },
           new Product
           {
               Id = 2,
               Title = "Beyond the Witch Trials",
               Description = "Witchcraft and Magic in Enlightenment Europe is an edited volume edited by the historians Owen Davies and Willem de Blécourt. It was first published by Manchester University Press in 2004. It consists of ten essays on the continued practice of magic and the belief in witchcraft in Europe during the European Enlightenment after the end of the witch trials in the early modern period. It was accompanied by Witchcraft Continued: Popular Magic in Modern Europe, dealing with the nineteenth and twentieth centuries, also published by Manchester University Press in 2004",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b5/Beyond_the_witch_trials.jpg",
               
               CategoryId = 1

           },
           new Product
           {
               Id = 3,
               Title = "Dreamtime",
               Description = "Concerning the Boundary between Wilderness and Civilization is an anthropological and philosophical study of the altered states of consciousness found in shamanism and European witchcraft written by German anthropologist Hans Peter Duerr. First published in 1978 by Syndikat Autoren-und Verlagsgesellschaft under the German title of Traumzeit: Über die Grenze zwischen Wildnis und Zivilisation, it was translated into English by the Hungarian-American anthropologist Felicitas Goodman and published by Basil Blackwell in 1985.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c5/Dreamtime%2C_German_version.jpg",
               
               CategoryId = 1

           },
           new Product
           {
               Id = 4,
               Title = "Her Hidden Children",
               Description = "The Rise of Wicca and Paganism in America is a historical study of Wicca and Contemporary Paganism in the United States. It was written by the American academic Chas S. Clifton of Colorado State University-Pueblo, and published by AltaMira Press in 2005.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a5/Her_Hidden_Children.jpg",
               CategoryId = 1

           },
           new Product
           {
               Id = 5,
               Title = "The Night Battles",
               Description = "Witchcraft and Agrarian Cults in the Sixteenth and Seventeenth Centuries is a historical study of the benandanti folk custom of 16th and 17th century Friuli, Northeastern Italy. It was written by the Italian historian Carlo Ginzburg, then of the University of Bologna, and first published by the company Giulio Einaudi in 1966 under the Italian title of I Benandanti: Stregoneria e culti agrari tra Cinquecento e Seicento. It was later translated into English by John and Anne Tedeschi and published by Routledge and Kegan Paul in 1983 with a new foreword written by the historian Eric Hobsbawm.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/44/The_Night_Battles.png",
               CategoryId = 1

           },
           new Product
           {
               Id = 6,
               Title = "Europe's Inner Demons",
               Description = "An Enquiry Inspired by the Great Witch-Hunt is a historical study of the beliefs regarding European witchcraft in Late Medieval and Early Modern Europe, with particular reference to the development of the witches' sabbat and its influence on the witch trials in the Early Modern period. It was written by the English historian Norman Cohn, then of the University of Sussex, and first published by Sussex University Press in association with Heinemann Educational Books in 1975. It was released as a part of a series of academic books entitled 'Studies in the Dynamics of Persecution and Extermination' that were funded by the Columbus Centre and edited by Cohn himself.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8c/Europe%27s_Inner_Demons.jpg",
               CategoryId = 1

           },
           new Product
           {
               Id = 7,
               Title = "Shaman of Oberstdorf",
               Description = "Chonrad Stoeckhlin and the Phantoms of the Night is a study of the arrest and trial of Chonrad Stoecklin (1549–1587), a German herdsman from the town of Oberstdorf who was accused and executed for the crime of witchcraft after experiencing a series of visions. Written by the German historian Wolfgang Behringer, himself a specialist in the Early Modern witch trials of Germany, Shaman of Oberstdorf was initially published in German as Chonrad Stoekhlin und die Nachtschar: Eine Geschichte aus der frühen Neuzeit by R. Piper GmbH & Co. in 1994. It was subsequently translated into English by H.C. Erik Midelfort and published in 1998 by the University of Virginia Press.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/08/Shaman_of_Oberstdorf.jpg",
                
               CategoryId = 1

           },
           new Product
           {
               Id = 8,
               Title = "Death Note Episode 1",
               Description = "Is a Japanese manga series written by Tsugumi Ohba and illustrated by Takeshi Obata. It was serialized in Shueisha's shōnen manga magazine Weekly Shōnen Jump from December 2003 to May 2006, with its 108 chapters collected in 12 tankōbon volumes. ",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/6f/Death_Note_Vol_1.jpg",
               CategoryId = 2

           },
           new Product
           {
               Id = 9,
               Title = "Death Note Episode 2",
               Description = "Is a Japanese manga series written by Tsugumi Ohba and illustrated by Takeshi Obata. It was serialized in Shueisha's shōnen manga magazine Weekly Shōnen Jump from December 2003 to May 2006, with its 108 chapters collected in 12 tankōbon volumes. ",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/31/Death_Note_2_The_Last_Name_poster.jpeg",
               CategoryId = 2
           },
           new Product
           {
               Id = 10,
               Title = "Shadows House",
               Description = "is a Japanese manga series written and illustrated by the duo So-ma-to (specifically, written and designed by Nori and illustrated by Hisshi).It has been serialized in Shueisha's seinen manga magazine Weekly Young Jump since September 2018, with the chapters collected in twelve tankōbon volumes as of October 2022. An anime television series adaptation by CloverWorks aired from April to July 2021. A second season aired from July to September 2022.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4a/Shadows_House_volume_1_cover.jpg",
               CategoryId = 2
           },
           new Product
           {
               Id = 11,
               Title = "Eden: It's an Endless World!",
               Description = "This is a science fiction manga by Japanese artist Hiroki Endo, published monthly in the Japanese magazine Monthly Afternoon. It is published in the United States by Dark Horse Comics, in the United Kingdom by Titan Books, and in Germany by Egmont Manga & Anime. Eden is set in the near future, following a pandemic called closure virus which killed 15 percent of the world's population, crippled or disfigured many more, and upset the world's political balance greatly. Eden is to some extent based on Gnostic mythology, with some characters, such as Ennoia, being named after Gnostic entities, and other Gnostic influences being seen in the themes of the ongoing story.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/9e/Edencover_07.jpg",
               CategoryId = 2
           },
           new Product
           {
               Id = 12,
               Title = "Tales of Suspense",
               Description = "Name of an American comic book anthology series and two one-shot comics published by Marvel Comics. The first, which ran from 1959 to 1968, began as a science-fiction anthology that served as a showcase for such artists as Jack Kirby, Steve Ditko, and Don Heck, then featured superheroes Captain America and Iron Man during the Silver Age of Comic Books before changing its title to Captain America with issue #100 (cover-dated April 1968). ",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/85/TalesOfSuspense1.jpg",
               CategoryId = 3
           },
           new Product
           {
               Id = 13,
               Title = "Iron Man",
               Description = "Iron Man is a superhero appearing in American comic books published by Marvel Comics. The character was co-created by writer and editor Stan Lee, developed by scripter Larry Lieber, and designed by artists Don Heck and Jack Kirby. The character made his first appearance in Tales of Suspense #39 (cover dated March 1963), and received his own title in Iron Man #1 (May 1968). In 1963, the character founded the Avengers superhero team with Thor, Ant-Man, Wasp and the Hulk.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/47/Iron_Man_%28circa_2018%29.png",
               CategoryId = 3
           },
           new Product
           {
               Id = 14,
               Title = "Tales to Astonish",
               Description = "The primary title bearing that name was published from January 1959 to March 1968. It began as a science-fiction anthology that served as a showcase for such artists as Jack Kirby and Steve Ditko, then featured superheroes during the period fans and historians call the Silver Age of Comic Books. It became The Incredible Hulk with issue No. 102 (April 1968). Its sister title was Tales of Suspense.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/72/Tales_astonish_001.jpg",
               CategoryId = 3
           },
           new Product
           {
               Id = 15,
               Title = "Namor",
               Description = "Also known as the Sub-Mariner, is a character appearing in American comic books published by Marvel Comics. Debuting in early 1939, the character was created by writer-artist Bill Everett for comic book packager Funnies Inc. Initially created for the unreleased comic Motion Picture Funnies Weekly, the character first appeared publicly in Marvel Comics #1 (cover-dated Oct. 1939), which was the first comic book from Timely Comics, the 1930s–1940s predecessor of Marvel Comics. During that period, known to historians and fans as the Golden Age of Comic Books, the Sub-Mariner was one of Timely's top three characters, along with Captain America and the original Human Torch. Moreover, Namor has also been described as the first comic book antihero.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/f7/NAMOR1cover-CMYKcrop.jpg",
               CategoryId = 3
           },
           new Product
           {
               Id = 16,
               Title = "The Incredible Hulk",
               Description = "Is an ongoing comic book series featuring the Marvel Comics superhero the Hulk and his alter ego Dr. Bruce Banner. First published in May 1962, the series ran for six issues before it was cancelled in March 1963, and the Hulk character began appearing in Tales to Astonish. With issue #102, Tales to Astonish was renamed to The Incredible Hulk in April 1968, becoming its second volume.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0f/Hulk1.jpg",
               CategoryId = 3
           },
           new Product
           {
               Id = 17,
               Title = "The Archaeology of Ritual and Magic",
               Description = "This is an archaeological study of the material evidence for ritual and magical practices in Europe, containing a particular emphasis on London and South East England. It was written by the English archaeologist Ralph Merrifield, the former deputy director of the Museum of London, and first published by B.T. Batsford in 1987",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8f/Archaeology_of_Ritual_and_Magic.jpg",
               CategoryId = 1
           },
           new Product
           {
               Id = 18,
               Title = "Caliban and the Witch: Women, the Body and Primitive Accumulation",
               Description = "This is a 2004 book by Italian-American intellectual Silvia Federici. Responding to both feminist and Marxist traditions, the book offers a critical alternative to Karl Marx's theory of primitive accumulation.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/2e/Caliban_and_the_Witch.jpg",
               CategoryId = 1
           },
           new Product
           {
               Id = 19,
               Title = "Satanism and Witchcraft",
               Description = "This is a book by Jules Michelet on the history of witchcraft. Originally published in Paris as La Sorcière in 1862, the first English translation appeared in London a year later.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Martin_van_Maele_-_La_Sorci%C3%A8re_06.jpg/800px-Martin_van_Maele_-_La_Sorci%C3%A8re_06.jpg",
               CategoryId = 1
           },
           new Product
           {
               Id = 20,
               Title = "Elixir",
               Description = "This is the debut young adult novel co-written by American entertainer Hilary Duff with Elise Allen. It was available at booksellers on October 12, 2010. It is the first in a series of books that Duff became committed to write. Elise Allen collaborated on the first book with Duff, and became committed to work jointly with her on the others. The book is now a New York Times Best Seller.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/16/Elixir.jpg",
               CategoryId = 1
           },
           new Product
           {
               Id = 21,
               Title = "The Devil's Elixirs",
               Description = "This  is a 1815 novel by E. T. A. Hoffmann.The basic idea for the story was adopted from Matthew Gregory Lewis's novel The Monk, which is itself mentioned in the text.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/E.T.A.Hoffmann_%281815%29.JPG/1024px-E.T.A.Hoffmann_%281815%29.JPG",
               CategoryId = 1
           },
           new Product
           {
               Id = 22,
               Title = "Origins of Marvel Comics",
               Description = "This is a 1974 collection of Marvel Comics comic book stories, selected and introduced by Marvel writer and editor Stan Lee. The book was published by Fireside Books, an imprint of Simon & Schuster, and was Marvel's first trade paperback collection",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/ab/Origins_of_Marvel_Comics.jpg",
               CategoryId = 3
           },
           new Product
           {
               Id = 23,
               Title = "Worlds' End",
               Description = "This is the eighth collection of issues in the DC Comics series The Sandman. It was written by Neil Gaiman; illustrated by Michael Allred, Gary Amaro, Mark Buckingham, Dick Giordano, Tony Harris, Steve Leialoha, Vince Locke, Shea Anton Pensa, Alec Stevens, Bryan Talbot, John Watkiss, and Michael Zulli; colored by Danny Vozzo; and lettered by Todd Klein. The stories in the collection first appeared in 1993. The collection first appeared in paperback and hardback editions in 1994 with an introduction by Stephen King. The collection's title, setting, and a number of its themes and images are also found in G.K.",
               ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/37/Worlds_End_%28cover%29.jpg",
               CategoryId = 3
           }
           );

            modelBuilder.Entity<ProductVariant>().HasData(

                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                 new ProductVariant
                 {
                     ProductId = 1,
                     ProductTypeId = 3,
                     Price = 23.99m,

                 },
                  new ProductVariant
                  {
                      ProductId = 1,
                      ProductTypeId = 4,
                      Price = 22.99m,
                      OriginalPrice = 39.99m
                  },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 2,
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 2,
                    Price = 10.99m,
                    OriginalPrice = 21.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 2,
                    Price = 14.99m,
                    OriginalPrice = 28.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 2,
                    Price = 26.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 3,
                    Price = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 2,
                    Price = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 5,
                    Price = 36.99m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 5,
                    Price = 27.99m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 5,
                    Price = 12.99m
                },
                new ProductVariant
                {
                    ProductId = 11,
                    ProductTypeId = 5,
                    Price = 66.99m,
                    OriginalPrice = 71.99m
                },
                new ProductVariant
                {
                    ProductId = 12,
                    ProductTypeId = 6,
                    Price = 46.99m,
                    OriginalPrice = 51.99m
                },
                new ProductVariant
                {
                    ProductId = 13,
                    ProductTypeId = 6,
                    Price = 16.99m
                },
                new ProductVariant
                {
                    ProductId = 14,
                    ProductTypeId = 6,
                    Price = 5.99m,
                    OriginalPrice = 21.99m
                },
                new ProductVariant
                {
                    ProductId = 15,
                    ProductTypeId = 6,
                    Price = 36.99m,
                    OriginalPrice = 51.99m
                },
                new ProductVariant
                {
                    ProductId = 16,
                    ProductTypeId = 7,
                    Price = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 17,
                    ProductTypeId = 4,
                    Price = 10.99m,
                    OriginalPrice = 21.99m
                },
                new ProductVariant
                {
                    ProductId = 18,
                    ProductTypeId = 3,
                    Price = 21.99m,
                    OriginalPrice = 39.99m
                },
                new ProductVariant
                {
                    ProductId = 19,
                    ProductTypeId = 3,
                    Price = 26.99m,
                    OriginalPrice = 44.99m
                },
                new ProductVariant
                {
                    ProductId = 20,
                    ProductTypeId = 4,
                    Price = 16.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 21,
                    ProductTypeId = 4,
                    Price = 22.99m,
                },
                new ProductVariant
                {
                    ProductId = 22,
                    ProductTypeId = 7,
                    Price = 36.99m,
                },
                new ProductVariant
                {
                    ProductId = 23,
                    ProductTypeId = 7,
                    Price = 6.99m,
                    OriginalPrice = 21.99m
                }
                ) ;

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
    }
}
