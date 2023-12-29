using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AmazingBooks.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class final2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderTotal = table.Column<double>(type: "float", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderHeaderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderHeaders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalTable: "OrderHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Fiction" },
                    { 2, 2, "Self Help" },
                    { 3, 3, "Science" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Tech City", "Tech Solution", "6669990000", "12121", "IL", "123 Tech St" },
                    { 2, "Vid City", "Vivid Books", "7779990000", "66666", "IL", "999 Vid St" },
                    { 3, "Lala land", "Readers Club", "1113335555", "99999", "NY", "999 Main St" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Chimamanda Ngozi Adichie", 1, "Purple Hibiscus' by Chimamanda Ngozi Adichie follows the lives of Kambili and her brother Jaja in privileged yet oppressive Nigeria. Sheltered by their fanatically religious father, they escape to their aunt during a military coup, discovering a world beyond their father's control. The novel explores adolescence, family bonds, and the pursuit of freedom amidst political turmoil. Adichie's poignant narrative unveils the silent struggles behind their seemingly perfect life, emphasizing the strength needed to confront familial tensions and embrace newfound possibilities. 'Purple Hibiscus' is a powerful exploration of resilience and liberation in the face of familial oppression.", "9781616202415", 99.0, 90.0, 80.0, 85.0, "Purple Hibiscus" },
                    { 2, "Chinua Achebe", 1, "\"Things Fall Apart\" by Chinua Achebe is a classic novel that explores the impact of colonialism on traditional African societies. Through the story of Okonkwo, a proud Igbo warrior, Achebe vividly portrays the cultural clash and the devastating consequences of European influence. This compelling narrative reflects on the complexities of change, tradition, and the resilience of the human spirit.", "9780385474542", 22.989999999999998, 19.989999999999998, 17.989999999999998, 18.989999999999998, "Things Fall Apart" },
                    { 3, "Stephen Hawking", 3, "<p>A Brief History of Time\" by Stephen Hawking is a groundbreaking exploration of the universe, delving into complex scientific concepts with clarity and wit. From the Big Bang to black holes, Hawking takes readers on a journey through the cosmos, unraveling the mysteries of space and time. This science classic continues to captivate audiences, offering a profound understanding of the universe and our place within it.</p>", "9780553380163", 24.949999999999999, 21.989999999999998, 19.989999999999998, 20.989999999999998, "A Brief History of Time" },
                    { 4, "Harper Lee", 1, "<p>\"To Kill a Mockingbird\" by Harper Lee is a timeless work of fiction that explores issues of racial injustice and moral growth in the American South. Set during the Great Depression, the novel follows the coming-of-age story of Scout Finch as her father, Atticus Finch, defends an innocent black man accused of rape. Lee's masterpiece is a powerful narrative that addresses themes of compassion, empathy, and the complexities of human nature.</p>", "9780061120084", 17.989999999999998, 15.99, 13.99, 14.99, "To Kill a Mockingbird" },
                    { 5, "Carol S. Dweck", 2, "<p>\"Mindset: The New Psychology of Success\" by Carol S. Dweck explores the power of mindset in shaping success. Dweck introduces the concepts of fixed and growth mindsets, illustrating how beliefs about one's abilities impact achievement. Filled with research and anecdotes, this self-help classic provides insights into fostering resilience, learning, and achieving one's full potential.</p>", "9780345472328", 16.989999999999998, 14.99, 12.99, 13.99, "Mindset" },
                    { 6, "James Clear", 2, "<p>\"Atomic Habits\" by James Clear is a transformative guide to building good habits and breaking bad ones. Clear delves into the science of habits, offering practical strategies to make tiny changes that lead to remarkable results. This self-help bestseller empowers readers to understand the mechanics of behavior and cultivate habits that align with their goals, leading to positive, lasting change.</p>", "9780735211292", 27.0, 23.989999999999998, 21.989999999999998, 22.989999999999998, "Atomic Habits" },
                    { 7, "James D. Watson", 3, "<p>\"The Double Helix\" by James D. Watson is a riveting account of the discovery of the structure of DNA. Watson, alongside Francis Crick and Maurice Wilkins, unravels the mystery of the double helix, marking a pivotal moment in the history of science. This groundbreaking work provides insights into the competitive and collaborative nature of scientific discovery.</p>", "9780743216302", 18.949999999999999, 16.989999999999998, 14.99, 15.99, "The Double Helix" },
                    { 8, "J.D. Salinger", 1, "<p>\"The Catcher in the Rye\" by J.D. Salinger is a classic novel narrated by Holden Caulfield, a disenchanted teenager navigating the complexities of adolescence. The story provides a poignant exploration of alienation, identity, and societal expectations, making it a timeless coming-of-age tale.</p>", "9780241950425", 19.989999999999998, 17.989999999999998, 15.99, 16.989999999999998, "The Catcher in the Rye" },
                    { 9, "Jen Sincero", 2, "<p>\"You Are a Badass\" by Jen Sincero is a motivational self-help book that encourages readers to embrace their inner awesomeness and live life to the fullest. With humor and practical advice, Sincero inspires personal development and empowers individuals to overcome challenges and achieve their goals.</p>", "9780762447695", 21.949999999999999, 19.989999999999998, 17.989999999999998, 18.989999999999998, "You Are a Badass" },
                    { 10, "Yuval Noah Harari", 3, "<p>\"Sapiens: A Brief History of Humankind\" by Yuval Noah Harari provides a compelling overview of the evolution of Homo sapiens. Harari explores the cognitive, agricultural, and scientific revolutions, offering insights into the collective journey of humanity.</p>", "9780062316110", 24.989999999999998, 21.989999999999998, 19.989999999999998, 20.989999999999998, "Sapiens" },
                    { 11, "George Orwell", 1, "<p>\"1984\" by George Orwell is a dystopian novel that explores the consequences of a totalitarian society. Orwell's portrayal of a surveillance state and the suppression of individuality remains a powerful commentary on political control and the impact of propaganda.</p>", "9780451524935", 16.989999999999998, 14.99, 12.99, 13.99, "1984" },
                    { 12, "Eckhart Tolle", 2, "<p>\"The Power of Now\" by Eckhart Tolle is a spiritual guide that emphasizes the importance of living in the present moment. Tolle explores the concept of mindfulness and offers practical teachings to achieve inner peace and enlightenment.</p>", "9781577314806", 23.0, 19.989999999999998, 17.989999999999998, 18.989999999999998, "The Power of Now" },
                    { 13, "Carl Sagan", 3, "<p>\"Cosmos\" by Carl Sagan is a captivating exploration of the universe. Sagan combines science and philosophy to convey the wonders of space and the significance of human exploration. This classic work continues to inspire awe and curiosity about the cosmos.</p>", "9780345539434", 30.0, 26.989999999999998, 24.989999999999998, 25.989999999999998, "Cosmos" },
                    { 14, "J.R.R. Tolkien", 1, "<p>\"The Lord of the Rings\" by J.R.R. Tolkien is an epic fantasy trilogy that follows the journey of Frodo Baggins to destroy the One Ring. Tolkien's rich world-building and intricate storytelling have made this series a literary masterpiece and a beloved classic.</p>", "9780618640157", 45.0, 39.990000000000002, 37.990000000000002, 38.990000000000002, "The Lord of the Rings" },
                    { 16, "Richard Dawkins", 3, "<p>\"The Selfish Gene\" by Richard Dawkins explores the gene's-eye view of evolution, presenting a groundbreaking perspective on natural selection. Dawkins elucidates the concept of genes as replicators, shaping the behavior of living organisms in the struggle for survival.</p>", "9780198788607", 19.949999999999999, 17.989999999999998, 15.99, 16.989999999999998, "The Selfish Gene" },
                    { 17, "Jane Austen", 1, "<p>\"Pride and Prejudice\" by Jane Austen is a classic novel that explores themes of love, class, and societal expectations. Austen's witty commentary and engaging characters make this timeless work a cornerstone of English literature.</p>", "9780141439518", 18.0, 15.99, 13.99, 14.99, "Pride and Prejudice" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { 1, "\\images\\products\\product-1\\d52714a8-c5f1-437d-b7da-27ea6fe65fdb.webp", 1 },
                    { 2, "\\images\\products\\product-2\\96e9e1f1-1b0e-4fb9-8743-0c722a68027a.webp", 2 },
                    { 3, "\\images\\products\\product-3\\d4fe26be-0d50-4975-9cfd-deec5040797c.jpg", 3 },
                    { 4, "\\images\\products\\product-4\\66fb28ad-0d50-4820-93c2-eeed6aefbca4.jpg", 4 },
                    { 5, "\\images\\products\\product-5\\352fc0f4-76a8-4d33-9ee4-cd4d0056405a.jpg", 5 },
                    { 6, "\\images\\products\\product-6\\aebed5b4-6f74-4341-834c-7f19246ce03c.webp", 6 },
                    { 7, "\\images\\products\\product-7\\72b10554-9bc2-44d5-9b78-01958746f6ec.jpg", 7 },
                    { 8, "\\images\\products\\product-8\\115fc1c8-bb4c-4cd7-a306-787796e3f121.jpg", 8 },
                    { 9, "\\images\\products\\product-9\\a9b02782-608f-4fd5-8755-72587426b821.jpg", 9 },
                    { 10, "\\images\\products\\product-10\\a382f490-7dbb-4263-8f16-e91d22a93ef8.jpg", 10 },
                    { 11, "\\images\\products\\product-11\\02158f4d-948e-4607-bb61-50471cf8db88.jpg", 11 },
                    { 12, "\\images\\products\\product-11\\b3a473c4-ce62-465b-b0c3-5ed07beecb9a.jpg", 11 },
                    { 13, "\\images\\products\\product-12\\d42e9622-f818-41b7-aace-6376bc4cd45e.jpg", 12 },
                    { 14, "\\images\\products\\product-13\\08827ed0-77bb-463e-b686-bedac13652da.webp", 13 },
                    { 15, "\\images\\products\\product-14\\7f04f2b2-9687-486b-9eb6-f25045dd8d17.jpg", 14 },
                    { 16, "\\images\\products\\product-16\\8c6fef26-af51-4f65-89e0-8b64897289fc.jpg", 16 },
                    { 17, "\\images\\products\\product-17\\f356745b-ce54-463b-8651-4c9daa922567.jpg", 17 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderHeaderId",
                table: "OrderDetails",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeaders_ApplicationUserId",
                table: "OrderHeaders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ApplicationUserId",
                table: "ShoppingCarts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "ShoppingCarts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "OrderHeaders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
