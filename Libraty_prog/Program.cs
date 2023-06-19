using LibraryManagement;
using Libraty_prog;

var libraryManagement = new LibraryManagementCore(DataSource.Books, DataSource.Users);

libraryManagement.DisplayAllBooks();
libraryManagement.DisplayAllUsers();