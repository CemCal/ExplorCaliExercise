using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExploreCaliWebApp.Models;

namespace ExploreCaliWebApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            var posts = new[]
            {
                new Post
                {
                    Title = "My blog post",
                    Posted = DateTime.Now,
                    Author = "Cem Calgici",
                    Body = "heheheheheh",
                },
                new Post
                {
                    Title = "My second blog post",
                    Posted = DateTime.Now,
                    Author = "Cem Calgici",
                    Body = "heheheheheheh xD",
                },
            };

            return View(posts);

        }

        public IActionResult Post(int year, int month, string key)
        {
            var post = new Post
            {
                Title = "My blog post",
                Posted = DateTime.Now,
                Author = "Cem Calgici",
                Body = "heheheheheheh",
            };
            return View(post);
        }
    }
}