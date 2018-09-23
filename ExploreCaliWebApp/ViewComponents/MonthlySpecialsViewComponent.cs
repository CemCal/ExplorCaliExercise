using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using ExploreCalifornia.Models;

namespace ExploreCaliWebApp.ViewComponents
{
    
   public class MonthlySpecialsViewComponent : ViewComponent
    {
        private readonly SpecialsDataContext _specials;

        public MonthlySpecialsViewComponent(SpecialsDataContext specials)
        {
            _specials = specials;
        }
        public IViewComponentResult Invoke()
        {
            var specials = _specials.GetMonthlySpecials();
            return View(specials);
        }
    }
}
