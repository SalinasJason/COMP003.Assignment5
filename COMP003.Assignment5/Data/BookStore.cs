using COMP003.Assignment5.Models;
namespace COMP003.Assignment5.Data
{
    public static class BookStore
    {
        public static List<Book> Books { get; } = new()
        {
            new Book { Id = 1, Title = "Of Mice and Men", Author = "John Steinbeck", Price = 14.99m },
            new Book { Id = 2, Title = "The Hunger Games", Author = "Suzanne Collins", Price = 19.99m },
            new Book { Id = 3, Title = "The Cat in the Hat", Author = "Dr. Seuss", Price = 7.99m },
        };

    }
}
