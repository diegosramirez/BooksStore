using BookStore.API.Features.Books.GetBook;
using BookStore.API.Features.Books.GetBooks;
using BookStore.API.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookStore.API.Data
{
    public class BookStoreData
    {
        private static readonly IList<Genre> _genres = new List<Genre>
        {
            new Genre { Id = Guid.NewGuid(), Name = "Fiction" },
            new Genre { Id = Guid.NewGuid(), Name = "Dystopian" },
            new Genre { Id = Guid.NewGuid(), Name = "Romance" },
            new Genre { Id = Guid.NewGuid(), Name = "Tragedy" },
            new Genre { Id = Guid.NewGuid(), Name = "Adventure" },
            new Genre { Id = Guid.NewGuid(), Name = "Fantasy" },
            new Genre { Id = Guid.NewGuid(), Name = "Historical" },
            new Genre { Id = Guid.NewGuid(), Name = "Psychological Fiction" },
            new Genre { Id = Guid.NewGuid(), Name = "Epic" },
            new Genre { Id = Guid.NewGuid(), Name = "Epic Poetry" },
            new Genre { Id = Guid.NewGuid(), Name = "Modernist" },
            new Genre { Id = Guid.NewGuid(), Name = "Historical Fiction" },
            new Genre { Id = Guid.NewGuid(), Name = "Post-apocalyptic Fiction" }
        };

        private IList<Book> _books = new List<Book>()
        {
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                ISBN = "9780061120084",
                PublishedDate = new DateOnly(1960, 7, 11),
                Genre = _genres.First(g => g.Name == "Fiction"),
                PageCount = 281,
                Description = "A novel about the serious issues of race and rape in 1930s Alabama.",
                Publisher = "J.B. Lippincott & Co."
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "1984",
                Author = "George Orwell",
                ISBN = "9780451524935",
                PublishedDate = new DateOnly(1949, 6, 8),
                Genre = _genres.First(g => g.Name == "Dystopian"),
                PageCount = 328,
                Description = "A dystopian novel set in a totalitarian society ruled by Big Brother.",
                Publisher = "Secker & Warburg"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                ISBN = "9781503290563",
                PublishedDate = new DateOnly(1813, 1, 28),
                Genre = _genres.First(g => g.Name == "Romance"),
                PageCount = 279,
                Description = "A romantic novel about manners, marriage, and morality in 19th-century England.",
                Publisher = "T. Egerton"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                ISBN = "9780743273565",
                PublishedDate = new DateOnly(1925, 4, 10),
                Genre = _genres.First(g => g.Name == "Tragedy"),
                PageCount = 180,
                Description = "A novel about the decline of the American Dream in the 1920s.",
                Publisher = "Charles Scribner's Sons"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "Moby-Dick",
                Author = "Herman Melville",
                ISBN = "9781503280786",
                PublishedDate = new DateOnly(1851, 10, 18),
                Genre = _genres.First(g => g.Name == "Adventure"),
                PageCount = 635,
                Description = "The quest of Captain Ahab to take revenge on the white whale, Moby Dick.",
                Publisher = "Harper & Brothers"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "The Catcher in the Rye",
                Author = "J.D. Salinger",
                ISBN = "9780316769488",
                PublishedDate = new DateOnly(1951, 7, 16),
                Genre = _genres.First(g => g.Name == "Fiction"),
                PageCount = 277,
                Description = "The story of Holden Caulfield, a teenager facing alienation and disillusionment.",
                Publisher = "Little, Brown and Company"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "The Hobbit",
                Author = "J.R.R. Tolkien",
                ISBN = "9780547928227",
                PublishedDate = new DateOnly(1937, 9, 21),
                Genre = _genres.First(g => g.Name == "Fantasy"),
                PageCount = 310,
                Description = "The adventure of Bilbo Baggins to reclaim the treasure guarded by Smaug.",
                Publisher = "George Allen & Unwin"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "War and Peace",
                Author = "Leo Tolstoy",
                ISBN = "9780199232765",
                PublishedDate = new DateOnly(1869, 1, 1),
                Genre = _genres.First(g => g.Name == "Historical"),
                PageCount = 1225,
                Description = "A novel chronicling the French invasion of Russia and its impact.",
                Publisher = "The Russian Messenger"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "Crime and Punishment",
                Author = "Fyodor Dostoevsky",
                ISBN = "9780486415871",
                PublishedDate = new DateOnly(1866, 1, 1),
                Genre = _genres.First(g => g.Name == "Psychological Fiction"),
                PageCount = 671,
                Description = "A psychological drama about morality and redemption.",
                Publisher = "The Russian Messenger"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "The Odyssey",
                Author = "Homer",
                ISBN = "9780140268867",
                PublishedDate = new DateOnly(1999, 1, 1),
                Genre = _genres.First(g => g.Name == "Epic"),
                PageCount = 541,
                Description = "An ancient Greek epic poem about the journey of Odysseus.",
                Publisher = "Ancient Greece"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "Jane Eyre",
                Author = "Charlotte Brontë",
                ISBN = "9780141441146",
                PublishedDate = new DateOnly(1847, 10, 16),
                Genre = _genres.First(g => g.Name == "Romance"),
                PageCount = 507,
                Description = "A novel about the struggles of an orphaned girl for love and independence.",
                Publisher = "Smith, Elder & Co."
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "The Divine Comedy",
                Author = "Dante Alighieri",
                ISBN = "9780199535644",
                PublishedDate = new DateOnly(1320, 1, 1),
                Genre = _genres.First(g => g.Name == "Epic Poetry"),
                PageCount = 798,
                Description = "A journey through Hell, Purgatory, and Paradise.",
                Publisher = "Italian Literature"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "The Lord of the Rings",
                Author = "J.R.R. Tolkien",
                ISBN = "9780544003415",
                PublishedDate = new DateOnly(1954, 7, 29),
                Genre = _genres.First(g => g.Name == "Fantasy"),
                PageCount = 1178,
                Description = "The epic quest to destroy the One Ring and save Middle-earth.",
                Publisher = "George Allen & Unwin"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "Brave New World",
                Author = "Aldous Huxley",
                ISBN = "9780060850524",
                PublishedDate = new DateOnly(1932, 8, 30),
                Genre = _genres.First(g => g.Name == "Dystopian"),
                PageCount = 268,
                Description = "A dystopian novel about a scientifically controlled World State.",
                Publisher = "Chatto & Windus"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "The Alchemist",
                Author = "Paulo Coelho",
                ISBN = "9780061122415",
                PublishedDate = new DateOnly(1988, 4, 1),
                Genre = _genres.First(g => g.Name == "Adventure"),
                PageCount = 208,
                Description = "A fable about following your dreams and finding your destiny.",
                Publisher = "HarperOne"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "Anna Karenina",
                Author = "Leo Tolstoy",
                ISBN = "9780143035008",
                PublishedDate = new DateOnly(1877, 1, 1),
                Genre = _genres.First(g => g.Name == "Romance"),
                PageCount = 864,
                Description = "A tragic love story set against the backdrop of Russian society.",
                Publisher = "The Russian Messenger"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "The Grapes of Wrath",
                Author = "John Steinbeck",
                ISBN = "9780143039433",
                PublishedDate = new DateOnly(1939, 4, 14),
                Genre = _genres.First(g => g.Name == "Historical Fiction"),
                PageCount = 464,
                Description = "The struggles of the Joad family during the Great Depression.",
                Publisher = "The Viking Press"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "Ulysses",
                Author = "James Joyce",
                ISBN = "9780199535675",
                PublishedDate = new DateOnly(1922, 2, 2),
                Genre = _genres.First(g => g.Name == "Modernist"),
                PageCount = 730,
                Description = "A day in the life of Leopold Bloom in Dublin.",
                Publisher = "Sylvia Beach"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "The Road",
                Author = "Cormac McCarthy",
                ISBN = "9780307387899",
                PublishedDate = new DateOnly(2006, 9, 26),
                Genre = _genres.First(g => g.Name == "Post-apocalyptic Fiction"),
                PageCount = 287,
                Description = "A father and son's journey through a desolate post-apocalyptic world.",
                Publisher = "Alfred A. Knopf"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Title = "The Old Man and the Sea",
                Author = "Ernest Hemingway",
                ISBN = "9780684801223",
                PublishedDate = new DateOnly(1952, 9, 1),
                Genre = _genres.First(g => g.Name == "Fiction"),
                PageCount = 127,
                Description = "An epic battle between an old fisherman and a giant marlin.",
                Publisher = "Charles Scribner's Sons"
            }
        };

        public IList<BookDto> GetBooks()
        {
            return _books.Select(book => new BookDto
            (
                book.Id,
                book.Title,
                book.Author,
                book.Description
            )).ToList();
        }

        public BookDetailsDto? GetBookById(Guid id)
        {
            var book = _books.SingleOrDefault(book => book.Id == id);

            if (book is null) return null;

            return new BookDetailsDto
            (
                book.Id,
                book.Title,
                book.Author,
                book.ISBN,
                book.PublishedDate,
                book.Genre.Name,
                book.PageCount,
                book.Description,
                book.Publisher
            );
        }

        public Book CreateBook(Book book)
        {
            book.Id = Guid.NewGuid();

            _books.Add(book);

            return book;
        }

        public bool DeleteBook(Guid id)
        {
            var book = _books.FirstOrDefault(book => book.Id == id);

            if (book is null)
            {
                return false;
            }

            _books.Remove(book);

            return true;
        }
    }
}
