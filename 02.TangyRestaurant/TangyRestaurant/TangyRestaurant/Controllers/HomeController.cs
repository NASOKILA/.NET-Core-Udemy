using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TangyRestaurant.Data;
using TangyRestaurant.Models;
using TangyRestaurant.Models.HomeViewModel;

namespace TangyRestaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {

            IndexViewModel indexViewModel = new IndexViewModel()
            {
                Categories = await _db.Categories.OrderBy(c => c.DisplayOrder).ToListAsync(),
                Coupons = await _db.Coupons.Where(c => c.IsActive == true).ToListAsync(), //we take only the active coupons
                MenuItems = await _db.MenuItems.Include(mi => mi.SubCategory).Include(mi => mi.Category).ToListAsync(),
                StatusMessage = ""
            };

            return View(indexViewModel);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
