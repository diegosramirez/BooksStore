using BookStore.API.Features.Books.GetBook;
using BookStore.API.Features.Books.GetBooks;
using BookStore.API.Models;

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

        private static readonly IList<Author> _authors = new List<Author>
        {
            new Author { Id = Guid.NewGuid(), Name = "Harper Lee" },
            new Author { Id = Guid.NewGuid(), Name = "George Orwell" },
            new Author { Id = Guid.NewGuid(), Name = "Jane Austen" },
            new Author { Id = Guid.NewGuid(), Name = "F. Scott Fitzgerald" },
            new Author { Id = Guid.NewGuid(), Name = "Herman Melville" },
            new Author { Id = Guid.NewGuid(), Name = "J.D. Salinger" },
            new Author { Id = Guid.NewGuid(), Name = "J.R.R. Tolkien" },
            new Author { Id = Guid.NewGuid(), Name = "Leo Tolstoy" },
            new Author { Id = Guid.NewGuid(), Name = "Fyodor Dostoevsky" },
            new Author { Id = Guid.NewGuid(), Name = "Homer" },
            new Author { Id = Guid.NewGuid(), Name = "Charlotte Brontë" },
            new Author { Id = Guid.NewGuid(), Name = "Dante Alighieri" },
            new Author { Id = Guid.NewGuid(), Name = "Aldous Huxley" },
            new Author { Id = Guid.NewGuid(), Name = "Paulo Coelho" },
            new Author { Id = Guid.NewGuid(), Name = "John Steinbeck" },
            new Author { Id = Guid.NewGuid(), Name = "James Joyce" },
            new Author { Id = Guid.NewGuid(), Name = "Cormac McCarthy" },
            new Author { Id = Guid.NewGuid(), Name = "Ernest Hemingway" }
        };

        private readonly IList<Book> _books;

        public BookStoreData()
        {
            _books = new List<Book>
            {
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "To Kill a Mockingbird",
                    AuthorId = _authors.First(a => a.Name == "Harper Lee").Id,
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
                    AuthorId = _authors.First(a => a.Name == "George Orwell").Id,
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
                    AuthorId = _authors.First(a => a.Name == "Jane Austen").Id,
                    ISBN = "9781503290563",
                    PublishedDate = new DateOnly(1813, 1, 28),
                    Genre = _genres.First(g => g.Name == "Romance"),
                    PageCount = 279,
                    Description = "A romantic novel about manners, marriage, and morality in 19th-century England.",
                    Publisher = "T. Egerton"
                },
            };
        }

        public IList<BookDto> GetBooks()
        {
            return _books.Select(book => new BookDto
            (
                book.Id,
                book.Title,
                _authors.First(a => a.Id == book.AuthorId).Name,
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
                _authors.First(a => a.Id == book.AuthorId).Name,
                book.ISBN,
                book.PublishedDate,
                book.Genre!.Name,
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
