using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using final.Models;
using Microsoft.AspNetCore.Mvc;
using quotable.Models;

namespace final.Controllers
{
    public class QuoteController:Controller{
        private QuoteContext _context;
        public QuoteController(QuoteContext context){
            _context = context;
        }
       
       [HttpPost]
       public IActionResult AddMovie(QuoteViewModel quote)
        {
//System.Console.WriteLine($"You hit the MovieController {movie.Director} * {movie.Length} * {movie.Movie}");
            TryValidateModel(quote);
            if (ModelState.IsValid)
            {
               // System.Console.WriteLine("***************&&&$%^^Model is valid.");
                //_context.Add(movie);
                //await _context.SaveChangesAsync();
                return RedirectToAction("Dashboard", "Dashboard");
            } else {
                DashboardViewModel data = new DashboardViewModel(){
                    QuoteForm = quote
                };
                return View("../Dashboard/Dashboard", data);
            }
            
        }
   }
}