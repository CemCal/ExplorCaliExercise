using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCaliWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCaliWebApp.ViewComponents
{
    public class RandomFactsDataContext : ViewComponent
    {
        private readonly RandomFactsDataContext _facts;

        public RandomFactsViewComponent(RandomFactsDataContext randomFacts)
        {
            _facts = randomFacts;
        }
        public IViewComponentResult Invoke()
        {
            var facts = _facts.GetRandomFacts();
            return View(facts);
        }
    
}
