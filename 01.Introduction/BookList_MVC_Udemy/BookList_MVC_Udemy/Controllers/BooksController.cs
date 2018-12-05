using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList_MVC_Udemy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookList_MVC_Udemy.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookListDbContext dbContext;

        public BooksController(BookListDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {

            ICollection<Book> Books = await this.dbContext.Books.ToListAsync();

            //we return the books to the view
            return View(Books);
        }


        [HttpGet]
        public IActionResult Create() {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken] //This is for protections from hackers
        public async Task<IActionResult> Create(Book book) {

            if (!ModelState.IsValid)
            {
                return View();
            }

            await this.dbContext.Books.AddAsync(book);

            await this.dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Book book = await this.dbContext.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }
            
            return View(book);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) {
                return NotFound();
            }

            Book book = await this.dbContext.Books.FindAsync(id);
            
            if (book == null)
            {
                return NotFound();
            }
            
            return View(book);
        }


        [HttpPost]
        [ValidateAntiForgeryToken] //This is for protections from hackers
        public async Task<IActionResult> Edit(Book book)
        {
            if (!ModelState.IsValid) {
                return View();
            }

            this.dbContext.Books.Update(book);

            await dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Book book = await this.dbContext.Books.FindAsync(id);
            
            return View(book);
        }


        [HttpPost]
        [ValidateAntiForgeryToken] //This is for protections from hackers
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book currentBook = await dbContext.Books.SingleOrDefaultAsync(b => b.Id == id);

            if (currentBook == null)
            {
                return NotFound();
            }
            
            dbContext.Books.Remove(currentBook);

            await dbContext.SaveChangesAsync();

            return RedirectToAction("Index");   
        }
    }
}