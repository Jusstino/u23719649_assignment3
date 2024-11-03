using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using u23719649_assignment3.Models;
using PagedList;
using PagedList.Mvc;

namespace u23719649_assignment3.Controllers
{
    public class HomeController : Controller
    {
        //Asychronous
        LibraryDBContext db = new LibraryDBContext();
        public async Task<ActionResult> Index(int? pageStudents, int? pageBooks)
        {
            var result = new StudentBooks
            {
                students = (await db.students.ToListAsync()).ToPagedList(pageStudents?? 1,10),
                books = (await db.books.Include(b => b.type).Include(b=>b.author).ToListAsync()).ToPagedList(pageBooks ?? 1, 10),
                borrows = await db.borrows.ToListAsync()
            };
            return View(result);
        }


        public async Task<ActionResult> Maintain(int? pageAuthors, int? pageTypes, int? pageBorrows)
        {
            var result = new AuthorTypesBorrows
            {
                authors = (await db.authors.ToListAsync()).ToPagedList(pageAuthors?? 1,5),
                types = (await db.types.ToListAsync()).ToPagedList(pageTypes?? 1, 5),
                borrows = (await db.borrows.Include(td=>td.book).Include(td=>td.student).ToListAsync()).ToPagedList(pageBorrows?? 1,10),
            };
            return View(result);
        }

        public ActionResult Report()
        {
            var result = new studentBorrows
            {
                borrows = db.borrows.ToList(),
                students = db.students.ToList()
            };
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}