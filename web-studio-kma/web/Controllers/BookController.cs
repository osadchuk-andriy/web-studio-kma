using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

using web.model;
using web_studio.dao;
using web_studio.model;
using web_studio.web.Models;

namespace web_studio.web.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            try
            {
                //implementation of IDatabaseInitializer that will delete, recreate,
                //and optionally re-seed the database with data only if the model has changed since the database was created.
                //This implementation require you to use the type of the Database Context because it’s a generic class.
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BookEntityContext>());
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<UsersEntityContext>());

                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult GetBookDetails()
        {
            var model = new List<BookModel>();
            try
            {
                using (var context = new BookEntityContext())
                {
                    var value = context.Books.ToList();
                    foreach (var book in value)
                    {
                        var bookModel = new BookModel();
                        bookModel.BookName = book.BookName;
                        bookModel.Author = book.Author;
                        bookModel.Edition = book.Edition;
                        bookModel.Publishing = book.Publishing;

                        model.Add(bookModel);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return PartialView("_BookDetailView", model);
        }

        public ActionResult InsertBookDetail()
        {
            try
            {
                for (int counter = 0; counter < 5; counter++)
                {
                    var book = new Book()
                    {
                        BookName = "Book " + counter,
                        Author = "Author " + counter,
                        Edition = "Edition " + counter,
                        Publishing = "Publishing " + counter
                    };
                    using (var context = new BookEntityContext())
                    {
                        context.Books.Add(book);
                        context.SaveChanges();
                    }
                }


            }
            catch (Exception)
            {
                throw;
            }
            return Json(true);
        }
    }
}