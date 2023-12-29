
using AmazingBooks.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AmazingBooks.DataAccess.Data
{

    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Fiction", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Self Help", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Science", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Tech Solution",
                    StreetAddress = "123 Tech St",
                    City = "Tech City",
                    PostalCode = "12121",
                    State = "IL",
                    PhoneNumber = "6669990000"
                },
                new Company
                {
                    Id = 2,
                    Name = "Vivid Books",
                    StreetAddress = "999 Vid St",
                    City = "Vid City",
                    PostalCode = "66666",
                    State = "IL",
                    PhoneNumber = "7779990000"
                },
                new Company
                {
                    Id = 3,
                    Name = "Readers Club",
                    StreetAddress = "999 Main St",
                    City = "Lala land",
                    PostalCode = "99999",
                    State = "NY",
                    PhoneNumber = "1113335555"
                }
                );


               modelBuilder.Entity<Product>().HasData(
    new Product
    {
        Id = 1,
        Title = "Purple Hibiscus",
        Author = "Chimamanda Ngozi Adichie",
        Description = "Purple Hibiscus' by Chimamanda Ngozi Adichie follows the lives of Kambili and her brother Jaja in privileged yet oppressive Nigeria. Sheltered by their fanatically religious father, they escape to their aunt during a military coup, discovering a world beyond their father's control. The novel explores adolescence, family bonds, and the pursuit of freedom amidst political turmoil. Adichie's poignant narrative unveils the silent struggles behind their seemingly perfect life, emphasizing the strength needed to confront familial tensions and embrace newfound possibilities. 'Purple Hibiscus' is a powerful exploration of resilience and liberation in the face of familial oppression.",
        ISBN = "9781616202415",
        ListPrice = 99,
        Price = 90,
        Price50 = 85,
        Price100 = 80,
        CategoryId = 1
    },
    new Product
    {
        Id = 2,
        Title = "Things Fall Apart",
        Author = "Chinua Achebe",
        Description = "\"Things Fall Apart\" by Chinua Achebe is a classic novel that explores the impact of colonialism on traditional African societies. Through the story of Okonkwo, a proud Igbo warrior, Achebe vividly portrays the cultural clash and the devastating consequences of European influence. This compelling narrative reflects on the complexities of change, tradition, and the resilience of the human spirit.",
        ISBN = "9780385474542",
        ListPrice = 22.99,
        Price = 19.99,
        Price50 = 18.99,
        Price100 = 17.99,
        CategoryId = 1
    },
    new Product
    {
        Id = 3,
        Title = "A Brief History of Time",
        Author = "Stephen Hawking",
        Description = "<p>A Brief History of Time\" by Stephen Hawking is a groundbreaking exploration of the universe, delving into complex scientific concepts with clarity and wit. From the Big Bang to black holes, Hawking takes readers on a journey through the cosmos, unraveling the mysteries of space and time. This science classic continues to captivate audiences, offering a profound understanding of the universe and our place within it.</p>",
        ISBN = "9780553380163",
        ListPrice = 24.95,
        Price = 21.99,
        Price50 = 20.99,
        Price100 = 19.99,
        CategoryId = 3
    },
    new Product
    {
        Id = 4,
        Title = "To Kill a Mockingbird",
        Author = "Harper Lee",
        Description = "<p>\"To Kill a Mockingbird\" by Harper Lee is a timeless work of fiction that explores issues of racial injustice and moral growth in the American South. Set during the Great Depression, the novel follows the coming-of-age story of Scout Finch as her father, Atticus Finch, defends an innocent black man accused of rape. Lee's masterpiece is a powerful narrative that addresses themes of compassion, empathy, and the complexities of human nature.</p>",
        ISBN = "9780061120084",
        ListPrice = 17.99,
        Price = 15.99,
        Price50 = 14.99,
        Price100 = 13.99,
        CategoryId = 1
    },
    new Product
    {
        Id = 5,
        Title = "Mindset",
        Author = "Carol S. Dweck",
        Description = "<p>\"Mindset: The New Psychology of Success\" by Carol S. Dweck explores the power of mindset in shaping success. Dweck introduces the concepts of fixed and growth mindsets, illustrating how beliefs about one's abilities impact achievement. Filled with research and anecdotes, this self-help classic provides insights into fostering resilience, learning, and achieving one's full potential.</p>",
        ISBN = "9780345472328",
        ListPrice = 16.99,
        Price = 14.99,
        Price50 = 13.99,
        Price100 = 12.99,
        CategoryId = 2
    },
     new Product
    {
        Id = 6,
        Title = "Atomic Habits",
        Author = "James Clear",
        Description = "<p>\"Atomic Habits\" by James Clear is a transformative guide to building good habits and breaking bad ones. Clear delves into the science of habits, offering practical strategies to make tiny changes that lead to remarkable results. This self-help bestseller empowers readers to understand the mechanics of behavior and cultivate habits that align with their goals, leading to positive, lasting change.</p>",
        ISBN = "9780735211292",
        ListPrice = 27,
        Price = 23.99,
        Price50 = 22.99,
        Price100 = 21.99,
        CategoryId = 2
    },
    new Product
    {
        Id = 7,
        Title = "The Double Helix",
        Author = "James D. Watson",
        Description = "<p>\"The Double Helix\" by James D. Watson is a riveting account of the discovery of the structure of DNA. Watson, alongside Francis Crick and Maurice Wilkins, unravels the mystery of the double helix, marking a pivotal moment in the history of science. This groundbreaking work provides insights into the competitive and collaborative nature of scientific discovery.</p>",
        ISBN = "9780743216302",
        ListPrice = 18.95,
        Price = 16.99,
        Price50 = 15.99,
        Price100 = 14.99,
        CategoryId = 3
    },
    new Product
    {
        Id = 8,
        Title = "The Catcher in the Rye",
        Author = "J.D. Salinger",
        Description = "<p>\"The Catcher in the Rye\" by J.D. Salinger is a classic novel narrated by Holden Caulfield, a disenchanted teenager navigating the complexities of adolescence. The story provides a poignant exploration of alienation, identity, and societal expectations, making it a timeless coming-of-age tale.</p>",
        ISBN = "9780241950425",
        ListPrice = 19.99,
        Price = 17.99,
        Price50 = 16.99,
        Price100 = 15.99,
        CategoryId = 1
    },
    new Product
    {
        Id = 9,
        Title = "You Are a Badass",
        Author = "Jen Sincero",
        Description = "<p>\"You Are a Badass\" by Jen Sincero is a motivational self-help book that encourages readers to embrace their inner awesomeness and live life to the fullest. With humor and practical advice, Sincero inspires personal development and empowers individuals to overcome challenges and achieve their goals.</p>",
        ISBN = "9780762447695",
        ListPrice = 21.95,
        Price = 19.99,
        Price50 = 18.99,
        Price100 = 17.99,
        CategoryId = 2
    },
    new Product
    {
        Id = 10,
        Title = "Sapiens",
        Author = "Yuval Noah Harari",
        Description = "<p>\"Sapiens: A Brief History of Humankind\" by Yuval Noah Harari provides a compelling overview of the evolution of Homo sapiens. Harari explores the cognitive, agricultural, and scientific revolutions, offering insights into the collective journey of humanity.</p>",
        ISBN = "9780062316110",
        ListPrice = 24.99,
        Price = 21.99,
        Price50 = 20.99,
        Price100 = 19.99,
        CategoryId = 3
    },
    new Product
    {
        Id = 11,
        Title = "1984",
        Author = "George Orwell",
        Description = "<p>\"1984\" by George Orwell is a dystopian novel that explores the consequences of a totalitarian society. Orwell's portrayal of a surveillance state and the suppression of individuality remains a powerful commentary on political control and the impact of propaganda.</p>",
        ISBN = "9780451524935",
        ListPrice = 16.99,
        Price = 14.99,
        Price50 = 13.99,
        Price100 = 12.99,
        CategoryId = 1
    },
    new Product
    {
        Id = 12,
        Title = "The Power of Now",
        Author = "Eckhart Tolle",
        Description = "<p>\"The Power of Now\" by Eckhart Tolle is a spiritual guide that emphasizes the importance of living in the present moment. Tolle explores the concept of mindfulness and offers practical teachings to achieve inner peace and enlightenment.</p>",
        ISBN = "9781577314806",
        ListPrice = 23,
        Price = 19.99,
        Price50 = 18.99,
        Price100 = 17.99,
        CategoryId = 2
    },
    new Product
    {
        Id = 13,
        Title = "Cosmos",
        Author = "Carl Sagan",
        Description = "<p>\"Cosmos\" by Carl Sagan is a captivating exploration of the universe. Sagan combines science and philosophy to convey the wonders of space and the significance of human exploration. This classic work continues to inspire awe and curiosity about the cosmos.</p>",
        ISBN = "9780345539434",
        ListPrice = 30,
        Price = 26.99,
        Price50 = 25.99,
        Price100 = 24.99,
        CategoryId = 3
    },
    new Product
    {
        Id = 14,
        Title = "The Lord of the Rings",
        Author = "J.R.R. Tolkien",
        Description = "<p>\"The Lord of the Rings\" by J.R.R. Tolkien is an epic fantasy trilogy that follows the journey of Frodo Baggins to destroy the One Ring. Tolkien's rich world-building and intricate storytelling have made this series a literary masterpiece and a beloved classic.</p>",
        ISBN = "9780618640157",
        ListPrice = 45,
        Price = 39.99,
        Price50 = 38.99,
        Price100 = 37.99,
        CategoryId = 1
    },
    new Product
    {
        Id = 16,
        Title = "The Selfish Gene",
        Author = "Richard Dawkins",
        Description = "<p>\"The Selfish Gene\" by Richard Dawkins explores the gene's-eye view of evolution, presenting a groundbreaking perspective on natural selection. Dawkins elucidates the concept of genes as replicators, shaping the behavior of living organisms in the struggle for survival.</p>",
        ISBN = "9780198788607",
        ListPrice = 19.95,
        Price = 17.99,
        Price50 = 16.99,
        Price100 = 15.99,
        CategoryId = 3
    },
    new Product
    {
        Id = 17,
        Title = "Pride and Prejudice",
        Author = "Jane Austen",
        Description = "<p>\"Pride and Prejudice\" by Jane Austen is a classic novel that explores themes of love, class, and societal expectations. Austen's witty commentary and engaging characters make this timeless work a cornerstone of English literature.</p>",
        ISBN = "9780141439518",
        ListPrice = 18,
        Price = 15.99,
        Price50 = 14.99,
        Price100 = 13.99,
        CategoryId = 1
    }

                );
            modelBuilder.Entity<ProductImage>().HasData(
     new ProductImage { Id = 1, ImageUrl = @"\images\products\product-1\d52714a8-c5f1-437d-b7da-27ea6fe65fdb.webp", ProductId = 1 },
     new ProductImage { Id = 2, ImageUrl = @"\images\products\product-2\96e9e1f1-1b0e-4fb9-8743-0c722a68027a.webp", ProductId = 2 },
     new ProductImage { Id = 3, ImageUrl = @"\images\products\product-3\d4fe26be-0d50-4975-9cfd-deec5040797c.jpg", ProductId = 3 },
     new ProductImage { Id = 4, ImageUrl = @"\images\products\product-4\66fb28ad-0d50-4820-93c2-eeed6aefbca4.jpg", ProductId = 4 },
     new ProductImage { Id = 5, ImageUrl = @"\images\products\product-5\352fc0f4-76a8-4d33-9ee4-cd4d0056405a.jpg", ProductId = 5 },
     new ProductImage { Id = 6, ImageUrl = @"\images\products\product-6\aebed5b4-6f74-4341-834c-7f19246ce03c.webp", ProductId = 6 },
     new ProductImage { Id = 7, ImageUrl = @"\images\products\product-7\72b10554-9bc2-44d5-9b78-01958746f6ec.jpg", ProductId = 7 },
     new ProductImage { Id = 8, ImageUrl = @"\images\products\product-8\115fc1c8-bb4c-4cd7-a306-787796e3f121.jpg", ProductId = 8 },
     new ProductImage { Id = 9, ImageUrl = @"\images\products\product-9\a9b02782-608f-4fd5-8755-72587426b821.jpg", ProductId = 9 },
     new ProductImage { Id = 10, ImageUrl = @"\images\products\product-10\a382f490-7dbb-4263-8f16-e91d22a93ef8.jpg", ProductId = 10 },
     new ProductImage { Id = 11, ImageUrl = @"\images\products\product-11\02158f4d-948e-4607-bb61-50471cf8db88.jpg", ProductId = 11 },
     new ProductImage { Id = 12, ImageUrl = @"\images\products\product-11\b3a473c4-ce62-465b-b0c3-5ed07beecb9a.jpg", ProductId = 11 },
     new ProductImage { Id = 13, ImageUrl = @"\images\products\product-12\d42e9622-f818-41b7-aace-6376bc4cd45e.jpg", ProductId = 12 },
     new ProductImage { Id = 14, ImageUrl = @"\images\products\product-13\08827ed0-77bb-463e-b686-bedac13652da.webp", ProductId = 13 },
     new ProductImage { Id = 15, ImageUrl = @"\images\products\product-14\7f04f2b2-9687-486b-9eb6-f25045dd8d17.jpg", ProductId = 14 },
     new ProductImage { Id = 16, ImageUrl = @"\images\products\product-16\8c6fef26-af51-4f65-89e0-8b64897289fc.jpg", ProductId = 16 },
     new ProductImage { Id = 17, ImageUrl = @"\images\products\product-17\f356745b-ce54-463b-8651-4c9daa922567.jpg", ProductId = 17 }

);

        }
    }
}