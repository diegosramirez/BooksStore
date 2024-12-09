using BookStore.API.Data;
using BookStore.API.Features.Books;
using BookStore.API.Features.Genre;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("BooksStore");

builder.Services.AddSqlServer<BookStoreContext>(connectionString);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<BookStoreData>();


var app = builder.Build();

app.InitializeDb();
app.MapBooks();
app.MapGenres();

app.Run();