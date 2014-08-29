/* Question 8.5
 
Design the data structures for an online book reader system. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter08_Q05
    {
        public class OnlineReaderSystem
        {
            private Library library = new Library();
            private UserManager userManager = new UserManager();
            private Display display = new Display();

            public Library GetLibary()
            {
                return this.library;
            }

            public User GetActiveUser()
            {
                throw new NotImplementedException();
            }

            public Book GetActiveBook()
            {
                throw new NotImplementedException();
            }
        }

        public class Library
        {
            private Dictionary<int, Book> books = new Dictionary<int, Book>();

            public Book AddBook(int id, string detail)
            {
                throw new NotImplementedException();
            }

            public void RemoveBook(Book book)
            {
            }

            public Book FindBook(int id)
            {
                throw new NotImplementedException();
            }
        }

        public class UserManager
        {
            private Dictionary<int, User> users = new Dictionary<int, User>();

            public User AddUser(int userId, string detail)
            {
                throw new NotImplementedException();
            }

            public void RemoveUser(User user)
            {
            }

            public User FindUser(int id)
            {
                throw new NotImplementedException();
            }
        }

        public class Display
        {
            public void DisplayUser(User user)
            {
            }

            public void DisplayBood(Book book)
            {
            }

            public void RefreshUserName()
            {
            }

            public void RefreshTitle()
            {
            }

            public void RefreshDetail()
            {
            }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Detail { get; set; }
        }

        public class User
        {
            public int UserID { get; set; }
            public string Detail { get; set; }
            public int AccountType { get; set; }

            public void RemoveMembership()
            {
            }
        }
    }
}
