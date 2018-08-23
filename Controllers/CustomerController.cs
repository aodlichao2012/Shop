using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Food_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Food_Shop.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        private readonly DbEntity db;
        public CustomerController(DbEntity context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            var cs = db.Customers;
            return View(await cs.ToListAsync());
        }
        public async Task<IActionResult> Search(string txtQ)
        {

            if (string.IsNullOrEmpty(txtQ))
            {
                return View("Index", await db.Customers.ToListAsync());
            }
            else
            {
                return View("Index", await db.Customers.Where(c => c.Name.Contains(txtQ)).ToListAsync());
            }
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cs = await db.Customers.SingleOrDefaultAsync(c => c.ID == id);
            if (cs == null)
            {
                return NotFound();
            }
            return View(cs);
        }

    }
}



