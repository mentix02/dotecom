using ecom.Data;
using Microsoft.EntityFrameworkCore;

namespace ecom.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(
                        new Category { Name = "Books" },
                        new Category { Name = "Grocery" },
                        new Category { Name = "Software" },
                        new Category { Name = "Furniture" },
                        new Category { Name = "Technology" },
                        new Category { Name = "Healthcare" }
                    );
                    context.SaveChanges();
                }
            }
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                if (!context.Products.Any())
                {
                    Product product;
                    product = new Product
                    {
                        Name = "Stuff Imagine Program Who",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Stuff+Imagine+Program+Who",
                        Description = "Our financial team fly include happen piece. Simply reduce station down occur certainly before. Test present month issue surface herself.",
                        CategoryId = 5,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Gray", Price = 4120.62M },
                            new ProductVariant { Name = "Green", Price = 12338.12M },
                            new ProductVariant { Name = "DarkSeaGreen", Price = 13866.28M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Available Mission Occur Happy Style",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Available+Mission+Occur+Happy+Style",
                        Description = "Indicate over citizen whether statement mouth. Successful hotel study later amount pressure. Church house democratic opportunity buy go different none. Speech theory them remain research.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LightSkyBlue", Price = 14293.22M },
                            new ProductVariant { Name = "DarkOliveGreen", Price = 14528.37M },
                            new ProductVariant { Name = "DeepSkyBlue", Price = 9631.67M },
                            new ProductVariant { Name = "BlanchedAlmond", Price = 10573.21M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Week Plant Scene Across Move",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Week+Plant+Scene+Across+Move",
                        Description = "Call that seem citizen note. System sing tough us nor about big. Consumer television available return.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LimeGreen", Price = 16991.77M },
                            new ProductVariant { Name = "MediumTurquoise", Price = 9836.4M },
                            new ProductVariant { Name = "MintCream", Price = 8313.34M },
                            new ProductVariant { Name = "AntiqueWhite", Price = 16517.14M },
                            new ProductVariant { Name = "PaleVioletRed", Price = 15752.54M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Education Type Difficult Day Because",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Education+Type+Difficult+Day+Because",
                        Description = "Blue total character girl once increase together industry. Big know my. True those game sport fast. Get hit probably behind section perform. Assume Democrat how health scene single.",
                        CategoryId = 3,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "HotPink", Price = 14069.7M },
                            new ProductVariant { Name = "LawnGreen", Price = 9744.5M },
                            new ProductVariant { Name = "DarkOrchid", Price = 18114.34M },
                            new ProductVariant { Name = "DarkOliveGreen", Price = 1250.37M },
                            new ProductVariant { Name = "PaleGreen", Price = 5633.67M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Job Picture",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Job+Picture",
                        Description = "Teacher time indeed particularly south bill yeah. Image music word far interesting weight relationship sometimes. Across need concern provide popular interest might.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Chartreuse", Price = 9583.22M },
                            new ProductVariant { Name = "Aquamarine", Price = 9490.33M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Try Suffer Development Ask Very",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Try+Suffer+Development+Ask+Very",
                        Description = "Information try four her. Data job few marriage face event. Identify investment charge while push. Yourself none husband light support.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "CornflowerBlue", Price = 2373.2M },
                            new ProductVariant { Name = "LightSteelBlue", Price = 8680.73M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Scene Man Purpose Former What",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Scene+Man+Purpose+Former+What",
                        Description = "At likely throughout between. Deal born this show hard level. Note us source. Option task watch dark. Need page arrive stand. Yard policy Congress single on teacher.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LightSalmon", Price = 581.0M },
                            new ProductVariant { Name = "SpringGreen", Price = 10007.84M },
                            new ProductVariant { Name = "Plum", Price = 4622.97M },
                            new ProductVariant { Name = "Brown", Price = 6462.82M },
                            new ProductVariant { Name = "LightSkyBlue", Price = 9970.5M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Listen At Bring",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Listen+At+Bring",
                        Description = "Clear professor other anyone thank question sit fill. Improve because rather fine. Condition level stage middle weight by. Hard listen response feel any. Mr nothing east prevent small.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Khaki", Price = 232.19M },
                            new ProductVariant { Name = "Beige", Price = 2236.11M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Through Someone Medical Official Story",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Through+Someone+Medical+Official+Story",
                        Description = "Middle boy response. Professor pattern return drop him gas class. Agent performance expert guy son. Loss television policy once. Treat left pressure society law figure easy.",
                        CategoryId = 3,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "YellowGreen", Price = 16206.4M },
                            new ProductVariant { Name = "LightBlue", Price = 10037.79M },
                            new ProductVariant { Name = "Plum", Price = 5606.51M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Already Agency Letter Executive",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Already+Agency+Letter+Executive",
                        Description = "Something onto nature do himself. Fill wish usually benefit nothing society everybody. Decade thus be four discover mouth.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Aqua", Price = 3108.48M },
                            new ProductVariant { Name = "MediumSlateBlue", Price = 7781.6M },
                            new ProductVariant { Name = "LavenderBlush", Price = 10337.98M },
                            new ProductVariant { Name = "LightGreen", Price = 6520.93M },
                            new ProductVariant { Name = "PaleVioletRed", Price = 13496.92M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "War Politics Management International Environment",
                        ImageUrl = "https://via.placeholder.com/300x200?text=War+Politics+Management+International+Environment",
                        Description = "Garden six beat human possible class despite decide. Bag book fish probably. Theory anything own close stand. Pm yard catch trip. Offer peace take girl push issue step whose.",
                        CategoryId = 3,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LightBlue", Price = 19853.79M },
                            new ProductVariant { Name = "Chocolate", Price = 15452.37M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Whole Understand Common",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Whole+Understand+Common",
                        Description = "Surface page various choice respond help. Gun camera them data market. Star which red travel. Us PM series look when red. Whose remain sea television community tax best. Man future make.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "DarkOrange", Price = 1229.8M },
                            new ProductVariant { Name = "Moccasin", Price = 222.93M },
                            new ProductVariant { Name = "Salmon", Price = 2546.81M },
                            new ProductVariant { Name = "Aqua", Price = 12102.47M },
                            new ProductVariant { Name = "LightSkyBlue", Price = 18253.91M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Possible Same Apply Else",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Possible+Same+Apply+Else",
                        Description = "Boy billion per cup. Than heavy despite someone affect economy better. Wind guy maintain program there north. Age put fund gun. Take interest animal relate.",
                        CategoryId = 3,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "MediumSeaGreen", Price = 12423.15M },
                            new ProductVariant { Name = "DarkSlateBlue", Price = 5722.7M },
                            new ProductVariant { Name = "Sienna", Price = 13483.23M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Old What",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Old+What",
                        Description = "Growth fear strategy hour paper air positive. Occur explain oil affect together. Thus skill ground room he father.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "HotPink", Price = 1126.15M },
                            new ProductVariant { Name = "PaleVioletRed", Price = 5670.77M },
                            new ProductVariant { Name = "Aquamarine", Price = 3275.51M },
                            new ProductVariant { Name = "Maroon", Price = 3082.96M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Use Myself",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Use+Myself",
                        Description = "Lose draw real difference. Remember age leg by. Maintain science opportunity since somebody sense discussion. There heart easy worker system you also public. Make over expert.",
                        CategoryId = 2,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "MistyRose", Price = 2482.86M },
                            new ProductVariant { Name = "FloralWhite", Price = 113.19M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Away Contain",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Away+Contain",
                        Description = "Five especially wide tell they direction edge. Issue everything there clearly. Likely unit through respond.",
                        CategoryId = 2,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "SkyBlue", Price = 18885.15M },
                            new ProductVariant { Name = "Beige", Price = 11122.59M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "News Standard Early Exist Focus",
                        ImageUrl = "https://via.placeholder.com/300x200?text=News+Standard+Early+Exist+Focus",
                        Description = "Still whether order later green attention read piece. Matter foreign study. Back how continue provide. Energy building case bad pattern.",
                        CategoryId = 5,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "DarkMagenta", Price = 3467.6M },
                            new ProductVariant { Name = "CadetBlue", Price = 12486.68M },
                            new ProductVariant { Name = "DarkRed", Price = 19727.26M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Term Focus Source",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Term+Focus+Source",
                        Description = "Little part this economic business imagine. Recognize field turn do unit local. Debate federal drive nice yes peace. Usually culture mouth instead evening wide. General whose week upon budget policy.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Violet", Price = 8019.18M },
                            new ProductVariant { Name = "MistyRose", Price = 3699.94M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Baby Loss Daughter",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Baby+Loss+Daughter",
                        Description = "Oil collection garden seven before. Soon bar lay suddenly truth boy two. Piece still class. Remain loss change wife risk develop media live. Next consider sit minute sit wide record.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "White", Price = 895.83M },
                            new ProductVariant { Name = "Green", Price = 13181.2M },
                            new ProductVariant { Name = "MediumSlateBlue", Price = 655.89M },
                            new ProductVariant { Name = "Navy", Price = 16799.93M },
                            new ProductVariant { Name = "MediumBlue", Price = 10064.56M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Through Pull Major Energy",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Through+Pull+Major+Energy",
                        Description = "Citizen many quality speech indeed. Standard officer seek. Under evening chair notice within. Teach show no it of treatment play. Experience director building hear.",
                        CategoryId = 2,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LightSkyBlue", Price = 12501.94M },
                            new ProductVariant { Name = "Silver", Price = 10782.9M },
                            new ProductVariant { Name = "LightCoral", Price = 18561.34M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Day Look",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Day+Look",
                        Description = "Purpose well dream state debate. Senior deal ask size always capital. Foot without step approach garden option. Nature surface deal must size point out really. Sure represent great wear nothing car.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "PaleGreen", Price = 3826.99M },
                            new ProductVariant { Name = "DarkSalmon", Price = 11929.87M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "After Culture Clear",
                        ImageUrl = "https://via.placeholder.com/300x200?text=After+Culture+Clear",
                        Description = "Thank laugh move way many song media PM. Build Mr strategy. Modern individual voice. Network market example first foot character. Situation player believe.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "BlanchedAlmond", Price = 2530.9M },
                            new ProductVariant { Name = "MediumVioletRed", Price = 18310.9M },
                            new ProductVariant { Name = "PaleGoldenRod", Price = 9320.19M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Building Together",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Building+Together",
                        Description = "Must investment seven represent me generation point. Up safe research practice. Yet create wonder full material. Challenge reflect country.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Ivory", Price = 6837.59M },
                            new ProductVariant { Name = "Orange", Price = 11672.72M },
                            new ProductVariant { Name = "LightGreen", Price = 14462.75M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Believe Audience Event",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Believe+Audience+Event",
                        Description = "Treatment later whole modern statement she. Stop employee visit similar. World red medical thus southern wear tree development. Cost outside building might consumer thousand.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "HotPink", Price = 13768.48M },
                            new ProductVariant { Name = "SlateGray", Price = 7785.16M },
                            new ProductVariant { Name = "Gold", Price = 2709.5M },
                            new ProductVariant { Name = "MediumBlue", Price = 10716.18M },
                            new ProductVariant { Name = "Bisque", Price = 4947.53M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Read Reveal Realize",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Read+Reveal+Realize",
                        Description = "Such until step clear. Turn station same husband. Once down hit expert home late science. Last son entire reduce often simply fact news.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "WhiteSmoke", Price = 17958.15M },
                            new ProductVariant { Name = "OliveDrab", Price = 10269.17M },
                            new ProductVariant { Name = "MistyRose", Price = 13527.97M },
                            new ProductVariant { Name = "MintCream", Price = 19618.92M },
                            new ProductVariant { Name = "Peru", Price = 6636.8M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Green Which Television War Writer",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Green+Which+Television+War+Writer",
                        Description = "Professional himself place summer free series billion. Eat within game special control. High staff strong girl nothing face nothing next.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Violet", Price = 17926.96M },
                            new ProductVariant { Name = "LightGray", Price = 7814.37M },
                            new ProductVariant { Name = "RosyBrown", Price = 15916.91M },
                            new ProductVariant { Name = "MediumSlateBlue", Price = 18685.29M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Husband But Break Poor End",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Husband+But+Break+Poor+End",
                        Description = "Shoulder win card glass past live share. Else animal large option forget bad present. Already from decision second deal either. Sure friend shoulder light table send measure. Current right yard.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "MediumVioletRed", Price = 5240.43M },
                            new ProductVariant { Name = "GreenYellow", Price = 561.59M },
                            new ProductVariant { Name = "LightSalmon", Price = 18507.74M },
                            new ProductVariant { Name = "AliceBlue", Price = 5725.56M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "What News Strategy",
                        ImageUrl = "https://via.placeholder.com/300x200?text=What+News+Strategy",
                        Description = "Structure nice through employee inside decision. Democrat newspaper enjoy from specific art key. Born say above name political enjoy none. Court hour worker stop wait race play.",
                        CategoryId = 2,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "RoyalBlue", Price = 18927.17M },
                            new ProductVariant { Name = "Khaki", Price = 3081.11M },
                            new ProductVariant { Name = "OrangeRed", Price = 18567.2M },
                            new ProductVariant { Name = "DarkKhaki", Price = 18055.94M },
                            new ProductVariant { Name = "Bisque", Price = 7621.9M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Member Authority",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Member+Authority",
                        Description = "Plan character health get method thousand begin send. Rise court ten mind include own such. Evidence city little girl but religious continue class. Charge full before rich whom media while.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                        new ProductVariant { Name = "NavajoWhite", Price = 3721.81M },
                        new ProductVariant { Name = "Gainsboro", Price = 12005.31M },
                        new ProductVariant { Name = "Olive", Price = 7540.5M },
                        new ProductVariant { Name = "WhiteSmoke", Price = 6603.9M }
                    }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Or Watch Rate Table",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Or+Watch+Rate+Table",
                        Description = "My air girl will. Understand reduce hold during paper. Firm American task let institution. Someone song common. American hair traditional fire often. These likely product today bed senior gun night.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LightGoldenRodYellow", Price = 7041.4M },
                            new ProductVariant { Name = "Teal", Price = 8488.8M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Keep He",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Keep+He",
                        Description = "Dog to than until scientist. Word street eight term particularly explain list stand. And become once wrong happen itself want establish.",
                        CategoryId = 3,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "GhostWhite", Price = 8752.99M },
                            new ProductVariant { Name = "MistyRose", Price = 10191.87M },
                            new ProductVariant { Name = "HoneyDew", Price = 9771.44M },
                            new ProductVariant { Name = "FloralWhite", Price = 15678.31M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "By Produce Hand Continue",
                        ImageUrl = "https://via.placeholder.com/300x200?text=By+Produce+Hand+Continue",
                        Description = "Will fast trial low operation go. Local able ahead job score leave. At strong happen hear institution hope. Clear particular term loss why. Land respond law word industry.",
                        CategoryId = 2,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "DeepPink", Price = 12884.39M },
                            new ProductVariant { Name = "Moccasin", Price = 4336.52M },
                            new ProductVariant { Name = "Green", Price = 2182.19M },
                            new ProductVariant { Name = "WhiteSmoke", Price = 19904.88M },
                            new ProductVariant { Name = "Fuchsia", Price = 16510.36M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Short She",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Short+She",
                        Description = "Wind source very help challenge. Power another common. Day several indeed sign both offer. Similar not rise bill wrong.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Indigo", Price = 6718.1M },
                            new ProductVariant { Name = "PaleVioletRed", Price = 9854.69M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Several Next",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Several+Next",
                        Description = "Benefit claim another decision science front. Wish store trip pressure key. Learn glass total law plant.",
                        CategoryId = 3,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "MediumSlateBlue", Price = 15138.78M },
                            new ProductVariant { Name = "MediumBlue", Price = 1788.42M },
                            new ProductVariant { Name = "Magenta", Price = 15231.34M },
                            new ProductVariant { Name = "LightCoral", Price = 13726.39M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Difference Young Administration National",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Difference+Young+Administration+National",
                        Description = "Model glass into mouth. Try apply available yet bill according bar father. Medical always ask know itself. Government stay stage statement. Very suggest newspaper we Republican three.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LightGreen", Price = 7478.33M },
                            new ProductVariant { Name = "DeepSkyBlue", Price = 14463.94M },
                            new ProductVariant { Name = "Fuchsia", Price = 5746.6M },
                            new ProductVariant { Name = "AliceBlue", Price = 8226.95M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Animal Many Answer Couple",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Animal+Many+Answer+Couple",
                        Description = "Under arm sort of above member. Next ready nearly behind economic. Always film meeting heart try energy both cold.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "MediumPurple", Price = 1619.67M },
                            new ProductVariant { Name = "Thistle", Price = 4470.24M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Positive Behind",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Positive+Behind",
                        Description = "Job experience seven best measure gas way. Police season Republican upon use or machine. Truth white husband hot finally best. Expert perform song different little represent.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "IndianRed", Price = 10169.57M },
                            new ProductVariant { Name = "Plum", Price = 15551.17M },
                            new ProductVariant { Name = "DarkGoldenRod", Price = 13764.94M },
                            new ProductVariant { Name = "LightSteelBlue", Price = 968.29M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Institution Sit",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Institution+Sit",
                        Description = "Cold note attorney subject price. School something international fear nor eight. Mother right avoid film. Argue choice pull write check computer.",
                        CategoryId = 2,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LightGreen", Price = 10556.8M },
                            new ProductVariant { Name = "Orchid", Price = 15348.15M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "International Field Of",
                        ImageUrl = "https://via.placeholder.com/300x200?text=International+Field+Of",
                        Description = "Life against affect bar each fire food. And turn your question fear social fine animal. Place center region. Tax coach work involve campaign still. Debate energy natural price.",
                        CategoryId = 2,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "DarkMagenta", Price = 12047.82M },
                            new ProductVariant { Name = "WhiteSmoke", Price = 6397.74M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Lawyer Town Article Spring",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Lawyer+Town+Article+Spring",
                        Description = "Himself really involve. Change picture true item single few. Table use industry risk evidence trip interview. Bit hundred floor song attention third pay.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "AntiqueWhite", Price = 7571.16M },
                            new ProductVariant { Name = "Red", Price = 8177.86M },
                            new ProductVariant { Name = "WhiteSmoke", Price = 1154.52M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Improve Audience",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Improve+Audience",
                        Description = "Light list hospital teacher. Program newspaper receive those strategy rather power. Beyond catch responsibility language. Several despite pay she letter according never.",
                        CategoryId = 2,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "DarkGray", Price = 11474.17M },
                            new ProductVariant { Name = "CadetBlue", Price = 18459.57M },
                            new ProductVariant { Name = "Blue", Price = 5518.49M },
                            new ProductVariant { Name = "MediumSeaGreen", Price = 4648.34M },
                            new ProductVariant { Name = "Orchid", Price = 7812.68M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Little Growth Reveal Carry Bring",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Little+Growth+Reveal+Carry+Bring",
                        Description = "Action people fly those sort. Social whether gun office. Interview prove safe second church walk. Also music technology. Relate more other challenge. Trial yes ask.",
                        CategoryId = 3,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "PaleGreen", Price = 386.37M },
                            new ProductVariant { Name = "Aquamarine", Price = 840.66M },
                            new ProductVariant { Name = "Gainsboro", Price = 19222.87M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "News Fall Man",
                        ImageUrl = "https://via.placeholder.com/300x200?text=News+Fall+Man",
                        Description = "Remain major condition enough style. Act clear name meeting can would increase debate. Simply course lose budget present particular network manage.",
                        CategoryId = 5,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Tan", Price = 8379.9M },
                            new ProductVariant { Name = "Chartreuse", Price = 8515.75M },
                            new ProductVariant { Name = "DarkKhaki", Price = 15102.84M },
                            new ProductVariant { Name = "FloralWhite", Price = 8673.41M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Ball Thought Catch Who Speak",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Ball+Thought+Catch+Who+Speak",
                        Description = "Rich name property teach. Property political member it air. Boy memory have become week American send away. Write window less probably. Point before would economic. Attack language glass second type.",
                        CategoryId = 2,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LimeGreen", Price = 10199.43M },
                            new ProductVariant { Name = "DarkKhaki", Price = 1841.97M },
                            new ProductVariant { Name = "DeepPink", Price = 13290.92M },
                            new ProductVariant { Name = "LemonChiffon", Price = 11174.52M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Fear Congress Hot",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Fear+Congress+Hot",
                        Description = "Property blood study tree accept scene. Tough social individual dream show young dinner. Claim direction black deal performance skill.",
                        CategoryId = 5,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Bisque", Price = 10027.7M },
                            new ProductVariant { Name = "RosyBrown", Price = 3162.69M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Ever Together Position Peace Activity",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Ever+Together+Position+Peace+Activity",
                        Description = "College her hospital. Weight drop could inside word tax part. Medical skill forget receive feeling admit. Bag month move great every your. Join player country building affect red ever.",
                        CategoryId = 3,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Azure", Price = 18619.87M },
                            new ProductVariant { Name = "Cornsilk", Price = 5458.6M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "House Better Actually",
                        ImageUrl = "https://via.placeholder.com/300x200?text=House+Better+Actually",
                        Description = "Employee music baby born process raise. Attention ten service. Natural a can on rule news question. Herself be source look treatment camera TV our.",
                        CategoryId = 2,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Aqua", Price = 7331.55M },
                            new ProductVariant { Name = "LightBlue", Price = 17367.76M },
                            new ProductVariant { Name = "LightPink", Price = 3044.2M },
                            new ProductVariant { Name = "Indigo", Price = 225.97M },
                            new ProductVariant { Name = "IndianRed", Price = 6303.47M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Prove Develop",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Prove+Develop",
                        Description = "Technology ball cover fund. Deep table other cold century. Mouth green trip past set. Manager positive whom unit. Market everything involve modern before.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Orchid", Price = 14828.5M },
                            new ProductVariant { Name = "CornflowerBlue", Price = 9049.59M },
                            new ProductVariant { Name = "Sienna", Price = 3435.28M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Add Must",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Add+Must",
                        Description = "Change better service law. Include kitchen these price develop generation notice. Choice what under him she card our. Imagine establish democratic general. Police sea far keep field rest soldier.",
                        CategoryId = 2,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "SteelBlue", Price = 3649.53M },
                            new ProductVariant { Name = "Fuchsia", Price = 16976.29M },
                            new ProductVariant { Name = "Chocolate", Price = 5186.61M },
                            new ProductVariant { Name = "PeachPuff", Price = 8725.28M },
                            new ProductVariant { Name = "LightYellow", Price = 15672.95M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Group Indeed Those",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Group+Indeed+Those",
                        Description = "Station late mission thus provide hear else. Answer three happen relate debate nor. People job activity whose tell. Individual test data environmental town. Rock build first phone heavy reflect.",
                        CategoryId = 3,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LightSteelBlue", Price = 13077.77M },
                            new ProductVariant { Name = "MediumTurquoise", Price = 4031.31M },
                            new ProductVariant { Name = "PowderBlue", Price = 12722.5M },
                            new ProductVariant { Name = "MidnightBlue", Price = 2131.63M },
                            new ProductVariant { Name = "GreenYellow", Price = 1007.56M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Drop Among Drop Ago More",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Drop+Among+Drop+Ago+More",
                        Description = "Memory sort summer offer small hit. Gun many ability adult may guess near. Single every cultural us work. Else find husband fast vote economic. Set in the book. Relate hot accept miss family red.",
                        CategoryId = 5,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Magenta", Price = 16479.32M },
                            new ProductVariant { Name = "Salmon", Price = 7124.1M },
                            new ProductVariant { Name = "Aqua", Price = 9719.59M },
                            new ProductVariant { Name = "MediumPurple", Price = 15382.21M },
                            new ProductVariant { Name = "Beige", Price = 17568.85M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Poor Suffer Crime Until But",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Poor+Suffer+Crime+Until+But",
                        Description = "Bed lawyer stock west. Land myself but plant lot. Approach before use if dinner. With art interview have generation matter conference. Stage tax child start fine pass.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "BlanchedAlmond", Price = 7293.87M },
                            new ProductVariant { Name = "Turquoise", Price = 14462.88M },
                            new ProductVariant { Name = "LightCyan", Price = 7908.37M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "House Task Question Up",
                        ImageUrl = "https://via.placeholder.com/300x200?text=House+Task+Question+Up",
                        Description = "Continue tough yes move after over within fish. Service herself eight kitchen. Stage east effect political. Democrat want center mean born modern. Some discuss energy process. Thought we where star.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LightGreen", Price = 4388.89M },
                            new ProductVariant { Name = "DarkGreen", Price = 4027.79M },
                            new ProductVariant { Name = "DarkGoldenRod", Price = 17071.44M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Food Offer Up College Seat",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Food+Offer+Up+College+Seat",
                        Description = "West close late fight green town. Second film recognize speech. Seven than thing wife. Ask consider time popular policy later. Population everyone field idea.",
                        CategoryId = 3,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "White", Price = 10577.13M },
                            new ProductVariant { Name = "Peru", Price = 17258.4M },
                            new ProductVariant { Name = "SkyBlue", Price = 3198.34M },
                            new ProductVariant { Name = "FloralWhite", Price = 121.74M },
                            new ProductVariant { Name = "LightSkyBlue", Price = 10217.75M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Trip Marriage Small Since Set",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Trip+Marriage+Small+Since+Set",
                        Description = "Often cup challenge process. Cultural music top million. Civil involve guy five run respond. Three husband account activity. Section animal thank once toward.",
                        CategoryId = 2,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "BlueViolet", Price = 4853.98M },
                            new ProductVariant { Name = "Cornsilk", Price = 10155.15M },
                            new ProductVariant { Name = "Orange", Price = 10450.6M },
                            new ProductVariant { Name = "LightSeaGreen", Price = 12766.61M },
                            new ProductVariant { Name = "Lavender", Price = 1992.18M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Herself Tv Order Character Do",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Herself+Tv+Order+Character+Do",
                        Description = "Pass mission night like. Believe trial although history meet eye. Identify process bad talk happen system. Magazine blue across parent movement food red.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Aqua", Price = 19061.56M },
                            new ProductVariant { Name = "LavenderBlush", Price = 5196.17M },
                            new ProductVariant { Name = "DimGray", Price = 8619.54M },
                            new ProductVariant { Name = "LightSkyBlue", Price = 13912.52M },
                            new ProductVariant { Name = "DarkKhaki", Price = 928.46M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Price Brother",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Price+Brother",
                        Description = "Impact beyond hour project box. Amount really region. Type per page blue develop. Sometimes low bill sea marriage reflect letter. Early team door walk hold. Ahead notice they bit foot apply.",
                        CategoryId = 3,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LimeGreen", Price = 3708.22M },
                            new ProductVariant { Name = "DarkKhaki", Price = 12102.26M },
                            new ProductVariant { Name = "Magenta", Price = 5975.65M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Pull If Sport",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Pull+If+Sport",
                        Description = "Entire artist benefit happen recently have sign. Yeah especially lay value tonight hand use and. Top beyond everything everyone recognize. Wall win theory will. Either rule carry.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Chartreuse", Price = 8271.96M },
                            new ProductVariant { Name = "DarkOrange", Price = 16144.75M },
                            new ProductVariant { Name = "Fuchsia", Price = 12325.77M },
                            new ProductVariant { Name = "SeaShell", Price = 15944.27M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Market Time My",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Market+Time+My",
                        Description = "Despite bag cultural really risk mean defense help. Natural coach particular but study road. See water exist that test. Likely action effort season program sister relationship.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "DarkGray", Price = 8190.42M },
                            new ProductVariant { Name = "PaleTurquoise", Price = 4267.15M },
                            new ProductVariant { Name = "DarkSeaGreen", Price = 19840.15M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "For Brother Age Mention Ten",
                        ImageUrl = "https://via.placeholder.com/300x200?text=For+Brother+Age+Mention+Ten",
                        Description = "Four development likely likely argue small recent. Drug beautiful difficult ahead answer. Window hit call stuff medical order.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "CadetBlue", Price = 13305.94M },
                            new ProductVariant { Name = "DarkMagenta", Price = 1583.95M },
                            new ProductVariant { Name = "Salmon", Price = 11906.98M },
                            new ProductVariant { Name = "DarkOliveGreen", Price = 12891.13M },
                            new ProductVariant { Name = "Tomato", Price = 9906.11M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Coach Spring",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Coach+Spring",
                        Description = "Rise certainly memory administration cold. Sport peace parent development operation. Professor this newspaper machine. His man health husband hospital pressure.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "CadetBlue", Price = 15156.31M },
                            new ProductVariant { Name = "DarkGreen", Price = 15950.44M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Practice Modern Total Become",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Practice+Modern+Total+Become",
                        Description = "Husband of he resource. Teach leg up into source simple. Spring while in accept suffer part. Score son learn forget expert far. But newspaper run point.",
                        CategoryId = 3,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "MediumPurple", Price = 11624.39M },
                            new ProductVariant { Name = "PaleTurquoise", Price = 17228.97M },
                            new ProductVariant { Name = "DimGray", Price = 456.76M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Visit Collection Remain",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Visit+Collection+Remain",
                        Description = "See director religious carry glass everyone six. This top enjoy indicate worry thus. Stuff rest table role argue yourself. Woman learn face region beautiful free.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "YellowGreen", Price = 3221.88M },
                            new ProductVariant { Name = "Brown", Price = 16254.5M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Budget Country Reality For",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Budget+Country+Reality+For",
                        Description = "Third view science hand. Agree possible traditional bit artist can manage study. Admit far coach right. Off enough discussion nothing him three million. Expect probably I.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "OldLace", Price = 7722.22M },
                            new ProductVariant { Name = "SeaShell", Price = 4705.9M },
                            new ProductVariant { Name = "PaleGoldenRod", Price = 14212.31M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Fly Huge Can Lead Ball",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Fly+Huge+Can+Lead+Ball",
                        Description = "Just another factor grow executive. Reflect about fine character upon glass. Former better too second type teacher hour. Agency structure like situation. Go national seven special lay state sport.",
                        CategoryId = 2,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Turquoise", Price = 17888.9M },
                            new ProductVariant { Name = "LavenderBlush", Price = 12217.33M },
                            new ProductVariant { Name = "LightYellow", Price = 18178.62M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Old National",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Old+National",
                        Description = "Consider sense body stuff. My note speech first talk several. Political house car instead operation research live.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Moccasin", Price = 714.85M },
                            new ProductVariant { Name = "PowderBlue", Price = 19731.94M },
                            new ProductVariant { Name = "Chartreuse", Price = 8759.56M },
                            new ProductVariant { Name = "Beige", Price = 1158.9M },
                            new ProductVariant { Name = "DarkKhaki", Price = 3319.46M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Security Power Public Glass Bank",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Security+Power+Public+Glass+Bank",
                        Description = "Practice bag really. Operation character join well. Smile old we building. The weight fish method apply project control. Final would fast sometimes cell job.",
                        CategoryId = 3,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Magenta", Price = 12319.37M },
                            new ProductVariant { Name = "BurlyWood", Price = 3042.64M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Democrat Bag",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Democrat+Bag",
                        Description = "Safe space paper serve expect drug finally. Form will win want. American hand score bad top. Two upon both real exist. Heart memory skin place arrive reality. Tell man miss computer task.",
                        CategoryId = 5,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "MediumSeaGreen", Price = 9432.97M },
                            new ProductVariant { Name = "DarkSlateBlue", Price = 15943.39M },
                            new ProductVariant { Name = "Tomato", Price = 4129.49M },
                            new ProductVariant { Name = "MediumAquaMarine", Price = 13199.63M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Simply Fast Again Billion",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Simply+Fast+Again+Billion",
                        Description = "Right home try school future hair so what. Attorney seat remember close area board author. Worry fight ok present. Yes morning improve enough.",
                        CategoryId = 5,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Pink", Price = 13686.11M },
                            new ProductVariant { Name = "PaleVioletRed", Price = 13601.32M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "How This Head",
                        ImageUrl = "https://via.placeholder.com/300x200?text=How+This+Head",
                        Description = "Kid tax miss cell accept walk. Happen practice decision dream approach debate. Instead figure provide argue age important.",
                        CategoryId = 5,
                        Variants = new List<ProductVariant> {
                        new ProductVariant { Name = "Gray", Price = 1390.77M },
                        new ProductVariant { Name = "DarkGreen", Price = 7306.49M }
                    }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Number American Up Dark Course",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Number+American+Up+Dark+Course",
                        Description = "Project save away guess statement but. Candidate interest believe without effect against type. West imagine from both.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "MediumTurquoise", Price = 2900.8M },
                            new ProductVariant { Name = "PaleGreen", Price = 6641.12M },
                            new ProductVariant { Name = "BlueViolet", Price = 11487.75M },
                            new ProductVariant { Name = "LightSteelBlue", Price = 1426.74M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Manager Peace",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Manager+Peace",
                        Description = "Every town letter. Day form first rock star party adult pretty. Behavior relationship low too. Full material detail tax. Treatment speech wind test cut special. Decade expect agency very must serve.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "HotPink", Price = 258.66M },
                            new ProductVariant { Name = "Snow", Price = 12221.61M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Rich Different Establish Bring",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Rich+Different+Establish+Bring",
                        Description = "Someone seven rise the probably red long. Also door Democrat cup nor true. Score own change effect. Performance run fill identify.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "DarkMagenta", Price = 654.47M },
                            new ProductVariant { Name = "Violet", Price = 13411.19M },
                            new ProductVariant { Name = "FireBrick", Price = 16735.96M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "College Allow Concern",
                        ImageUrl = "https://via.placeholder.com/300x200?text=College+Allow+Concern",
                        Description = "His structure agency close physical. Worker return hour alone region themselves. Democratic member figure. Find already statement common public. Bad crime eye take wind.",
                        CategoryId = 3,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "PaleGreen", Price = 11222.2M },
                            new ProductVariant { Name = "OldLace", Price = 19555.6M },
                            new ProductVariant { Name = "HoneyDew", Price = 11915.29M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Kitchen Hear Recent Toward Writer",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Kitchen+Hear+Recent+Toward+Writer",
                        Description = "Scientist improve however evidence. Stuff investment whether kid. Name computer production already hour black discussion. Other model dog police mission together seem. College section rather high.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "RoyalBlue", Price = 9443.31M },
                            new ProductVariant { Name = "Sienna", Price = 5360.88M },
                            new ProductVariant { Name = "SpringGreen", Price = 4067.67M },
                            new ProductVariant { Name = "Black", Price = 2207.43M },
                            new ProductVariant { Name = "Lavender", Price = 4885.92M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Clear Small Majority",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Clear+Small+Majority",
                        Description = "Image natural wish something coach. Should strategy song. End hospital treat give glass read. Move team certainly. Room no because billion significant base.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LightGoldenRodYellow", Price = 16408.37M },
                            new ProductVariant { Name = "Beige", Price = 5884.64M },
                            new ProductVariant { Name = "Linen", Price = 2105.24M },
                            new ProductVariant { Name = "PaleGoldenRod", Price = 4938.13M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Real Time Strong",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Real+Time+Strong",
                        Description = "Bit argue sometimes responsibility. Moment defense public building clear study something memory. Minute police success reality. Half join yeah education. Discussion other worry dinner ask.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "DarkTurquoise", Price = 8752.61M },
                            new ProductVariant { Name = "Brown", Price = 19227.97M },
                            new ProductVariant { Name = "LightCoral", Price = 15959.79M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Fire Play",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Fire+Play",
                        Description = "Specific about myself drop behavior feel create. News big sport wish. Think as party difference fill. System hand listen quickly under city two popular.",
                        CategoryId = 5,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "MediumSpringGreen", Price = 19408.8M },
                            new ProductVariant { Name = "FloralWhite", Price = 2469.18M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Action Glass House Democrat Day",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Action+Glass+House+Democrat+Day",
                        Description = "Become even include try plant although. Significant important side send even surface responsibility throughout. Ever short majority.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "SeaGreen", Price = 7674.98M },
                            new ProductVariant { Name = "LightSeaGreen", Price = 9176.5M },
                            new ProductVariant { Name = "BurlyWood", Price = 17865.5M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Impact Factor Politics",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Impact+Factor+Politics",
                        Description = "Police method effort pull it. Miss billion through blue defense. Door paper argue child thought minute husband. Debate feeling I sport performance. Carry dog stuff.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Lime", Price = 7728.6M },
                            new ProductVariant { Name = "RosyBrown", Price = 11095.63M },
                            new ProductVariant { Name = "Maroon", Price = 18237.64M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Bad Moment Film Shake",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Bad+Moment+Film+Shake",
                        Description = "Trial get girl choice his role lot. Site blue sell relate technology.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "DarkGreen", Price = 13370.8M },
                            new ProductVariant { Name = "Olive", Price = 13867.88M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Reach Expert Event Ago Almost",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Reach+Expert+Event+Ago+Almost",
                        Description = "Pick list strategy money energy field look. Throw job little white choose believe against. Still study scientist real.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "RoyalBlue", Price = 11362.58M },
                            new ProductVariant { Name = "SkyBlue", Price = 16332.8M },
                            new ProductVariant { Name = "FireBrick", Price = 5808.23M },
                            new ProductVariant { Name = "FloralWhite", Price = 6723.86M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Performance Say Because Despite",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Performance+Say+Because+Despite",
                        Description = "Health activity bit natural might subject. Age born side trial customer represent artist side. Scientist man this common example science civil.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "CadetBlue", Price = 675.65M },
                            new ProductVariant { Name = "LawnGreen", Price = 8073.77M },
                            new ProductVariant { Name = "OldLace", Price = 16985.46M },
                            new ProductVariant { Name = "Chocolate", Price = 12017.61M },
                            new ProductVariant { Name = "AntiqueWhite", Price = 4111.88M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Movie Subject Always",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Movie+Subject+Always",
                        Description = "Agent second statement blood. Score data successful identify blue. Family store tax reflect body ago. Very trade film.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "SpringGreen", Price = 18456.0M },
                            new ProductVariant { Name = "PaleGreen", Price = 5404.85M },
                            new ProductVariant { Name = "IndianRed", Price = 7386.26M },
                            new ProductVariant { Name = "FloralWhite", Price = 6252.64M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Way Role Less Mother",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Way+Role+Less+Mother",
                        Description = "Now event together main land. Imagine dream draw foot like charge house good. Agent site word scientist. Lose movement occur whether eye. Coach reach to vote.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Ivory", Price = 4574.33M },
                            new ProductVariant { Name = "MediumPurple", Price = 13367.93M },
                            new ProductVariant { Name = "Linen", Price = 14883.25M },
                            new ProductVariant { Name = "LightCoral", Price = 10865.69M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Sport Leave Matter",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Sport+Leave+Matter",
                        Description = "Decide less type lead summer claim offer fire. Like someone human away wait why method.",
                        CategoryId = 5,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LightCyan", Price = 19621.6M },
                            new ProductVariant { Name = "Yellow", Price = 16642.65M },
                            new ProductVariant { Name = "BurlyWood", Price = 12915.2M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Tax Often Picture Impact All",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Tax+Often+Picture+Impact+All",
                        Description = "Trip address realize perhaps necessary environment. Yourself draw policy. Maybe top few agree leg. Executive interest dream support city.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Sienna", Price = 19568.41M },
                            new ProductVariant { Name = "HoneyDew", Price = 11607.88M },
                            new ProductVariant { Name = "Indigo", Price = 578.58M },
                            new ProductVariant { Name = "DarkCyan", Price = 4800.31M },
                            new ProductVariant { Name = "FloralWhite", Price = 3035.0M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Give Important Character",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Give+Important+Character",
                        Description = "Sometimes establish prevent deal movie alone. Former attack free fire. Customer together contain well talk. Early activity view no onto employee. They time sound star describe.",
                        CategoryId = 2,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LimeGreen", Price = 5051.72M },
                            new ProductVariant { Name = "ForestGreen", Price = 6768.72M },
                            new ProductVariant { Name = "SlateGray", Price = 15298.67M },
                            new ProductVariant { Name = "DarkOliveGreen", Price = 10486.65M },
                            new ProductVariant { Name = "CornflowerBlue", Price = 3770.62M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Edge Catch",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Edge+Catch",
                        Description = "Buy ask green field wife financial. Buy above success sea none rock quite. Worry fly teach term message. Family behind sell theory hope year. Civil nice defense particularly care live.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Red", Price = 13088.94M },
                            new ProductVariant { Name = "Plum", Price = 2360.6M },
                            new ProductVariant { Name = "Azure", Price = 17879.15M },
                            new ProductVariant { Name = "DarkKhaki", Price = 4040.27M },
                            new ProductVariant { Name = "DarkGreen", Price = 9585.73M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Country Hear Home",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Country+Hear+Home",
                        Description = "Find real network myself center affect. Question easy explain into. Now interest least point.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "DarkGray", Price = 15085.1M },
                            new ProductVariant { Name = "MediumVioletRed", Price = 15261.91M },
                            new ProductVariant { Name = "HoneyDew", Price = 7657.72M },
                            new ProductVariant { Name = "Pink", Price = 17368.95M },
                            new ProductVariant { Name = "SeaShell", Price = 19875.51M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Later Scientist Protect Knowledge Wait",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Later+Scientist+Protect+Knowledge+Wait",
                        Description = "These discuss exactly quality recent only than. Quality this professional much. Participant those best road.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "MediumSlateBlue", Price = 4003.39M },
                            new ProductVariant { Name = "AntiqueWhite", Price = 12646.66M },
                            new ProductVariant { Name = "MediumSpringGreen", Price = 9958.22M },
                            new ProductVariant { Name = "Gainsboro", Price = 17524.99M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Office Article Coach Rock Report",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Office+Article+Coach+Rock+Report",
                        Description = "Whatever fast charge serve produce none opportunity. Stuff number street. Hour room some girl personal daughter. Put among necessary especially. Laugh that same raise mouth.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "SlateBlue", Price = 16543.6M },
                            new ProductVariant { Name = "OrangeRed", Price = 1529.78M },
                            new ProductVariant { Name = "Peru", Price = 656.11M },
                            new ProductVariant { Name = "SlateGray", Price = 14359.78M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Audience Focus",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Audience+Focus",
                        Description = "Try third stay effort center must. Rise after part. Property despite baby old. Sister foot woman myself phone forward think.",
                        CategoryId = 1,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "SlateBlue", Price = 18060.47M },
                            new ProductVariant { Name = "Thistle", Price = 6163.62M },
                            new ProductVariant { Name = "RosyBrown", Price = 12669.85M },
                            new ProductVariant { Name = "DarkSalmon", Price = 14403.44M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Difference Election Goal Score",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Difference+Election+Goal+Score",
                        Description = "Travel hard PM what. Price why brother poor. Marriage fire group well whom woman. Thing program worry ball.",
                        CategoryId = 5,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "LawnGreen", Price = 14283.2M },
                            new ProductVariant { Name = "Blue", Price = 19231.75M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "On Eat Trial Right Perform",
                        ImageUrl = "https://via.placeholder.com/300x200?text=On+Eat+Trial+Right+Perform",
                        Description = "Throw power thousand top account box to. Cold detail speech trouble talk money.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Purple", Price = 6867.77M },
                            new ProductVariant { Name = "DarkGoldenRod", Price = 7941.82M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Myself Character Relationship Book Specific",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Myself+Character+Relationship+Book+Specific",
                        Description = "Oil cost memory red couple picture. Agent special begin answer indicate. Difference commercial phone present thank risk computer. Sell look choose Congress customer. Effect find finish.",
                        CategoryId = 3,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Chocolate", Price = 4231.85M },
                            new ProductVariant { Name = "MediumSpringGreen", Price = 9507.15M },
                            new ProductVariant { Name = "DarkSeaGreen", Price = 8726.96M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Sound Different",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Sound+Different",
                        Description = "Political read individual second window. Candidate agree mission leave eight teach age follow.",
                        CategoryId = 2,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Linen", Price = 8573.67M },
                            new ProductVariant { Name = "Red", Price = 18673.0M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Occur Movie Language",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Occur+Movie+Language",
                        Description = "Network staff stock item. Late close name news social show. Skin something interesting key.",
                        CategoryId = 6,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Olive", Price = 16359.43M },
                            new ProductVariant { Name = "Teal", Price = 15208.43M },
                            new ProductVariant { Name = "SeaShell", Price = 2127.7M },
                            new ProductVariant { Name = "PaleTurquoise", Price = 15667.58M },
                            new ProductVariant { Name = "Aquamarine", Price = 11975.37M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Worry Majority",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Worry+Majority",
                        Description = "Raise with world single dog. Raise positive them compare modern place. Idea miss staff program method. Role office long serve few reflect.",
                        CategoryId = 5,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "AntiqueWhite", Price = 2201.82M },
                            new ProductVariant { Name = "Thistle", Price = 18146.67M },
                            new ProductVariant { Name = "LavenderBlush", Price = 8968.3M },
                            new ProductVariant { Name = "PaleGoldenRod", Price = 3898.51M }
                        }
                    };
                    context.Products.Add(product);
                    context.SaveChanges();

                    product = new Product
                    {
                        Name = "Billion All Education Surface",
                        ImageUrl = "https://via.placeholder.com/300x200?text=Billion+All+Education+Surface",
                        Description = "Line may technology only almost some opportunity feeling. Think college necessary deal yeah but machine. Now its rather oil. Actually outside American foot. Out party take control increase.",
                        CategoryId = 4,
                        Variants = new List<ProductVariant> {
                            new ProductVariant { Name = "Blue", Price = 6947.7M },
                            new ProductVariant { Name = "Sienna", Price = 12764.88M },
                            new ProductVariant { Name = "Purple", Price = 6475.51M },
                            new ProductVariant { Name = "GoldenRod", Price = 5252.53M },
                            new ProductVariant { Name = "LightYellow", Price = 12198.9M }
                        }
                    };
                }
            }
        }
    }
}
