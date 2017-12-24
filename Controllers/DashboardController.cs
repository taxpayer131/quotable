using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quotable.Models;

namespace final.Controllers
{
    public class DashboardController:Controller{
        private QuoteContext _context;
        public DashboardController(QuoteContext context){
            _context = context;
        }
        public IActionResult Dashboard(){
            DashboardViewModel data= new DashboardViewModel(){
                QuoteForm= new QuoteViewModel()
            };
            return View(data);
        }
    }
}