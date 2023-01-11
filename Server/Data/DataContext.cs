namespace EcommerceProject.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData
            (
                new Product
                {
                    Id = 1,
                    Title = "Clean Code",
                    Description = "Clean Code is divided into three parts. The first describes the principles, patterns, and practices of writing clean code. The second part consists of several case studies of increasing complexity. Each case study is an exercise in cleaning up code—of transforming a code base that has some problems into one that is sound and efficient. The third part is the payoff: a single chapter containing a list of heuristics and “smells” gathered while creating the case studies. The result is a knowledge base that describes the way we think when we write, read, and clean code.",
                    ImageUrl = "https://m.media-amazon.com/images/I/41xShlnTZTL._SX258_BO1,204,203,200_QL70_ML2_.jpg",
                    Price = 89.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "The Pragmatic Programmer",
                    Description = "Dave Thomas and Andy Hunt wrote the first edition of this influential book in 1999 to help their clients create better software and rediscover the joy of coding. These lessons have helped a generation of programmers examine the very essence of software development, independent of any particular language, framework, or methodology, and the Pragmatic philosophy has spawned hundreds of books, screencasts, and audio books, as well as thousands of careers and success stories.",
                    ImageUrl = "https://m.media-amazon.com/images/I/51IA4hT6jrL._SX380_BO1,204,203,200_.jpg",
                    Price = 69.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Head First Design Patterns",
                    Description = "You know you don't want to reinvent the wheel, so you look to Design Patterns: the lessons learned by those who've faced the same software design problems. With Design Patterns, you get to take advantage of the best practices and experience of others so you can spend your time on something more challenging. Something more fun. This book shows you the patterns that matter, when to use them and why, how to apply them to your own designs, and the object-oriented design principles on which they're based. Join hundreds of thousands of developers who've improved their object-oriented design skills through Head First Design Patterns.",
                    ImageUrl = "https://m.media-amazon.com/images/I/51rmlxN57sL._SX430_BO1,204,203,200_.jpg",
                    Price = 59.99m
                }
            );
        }

        public DbSet<Product> Products { get; set; }
    }
}
