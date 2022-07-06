using BookStory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookStory.Controllers
{
    public class HomeController : Controller
    {
        readonly StoryDBContext context = new();

        public IActionResult Index(int id)
        {
            List<Category> categories = null;
            categories = context.Categories.ToList();
            ViewBag.Categories = categories;
            List<Story> stories = new();
            List<StoriesCategory> storiesCategories = new();
            storiesCategories = context.StoriesCategories.Where(x => x.Cid == id).ToList();
            if (id == 0)
            {
                stories = context.Stories.Take(16).ToList();
            }
            else
            {
                foreach (StoriesCategory sc in storiesCategories)
                {
                    foreach (Story story in context.Stories.ToList())
                    {
                        if (story.Sid == sc.Sid)
                        {
                            stories.Add(story);
                        }
                    }
                }
            }
            ViewBag.Stories = stories.Take(16);
            ViewBag.CurrentId = id;
            List<Chapter> listNewChapters = new();
            listNewChapters = context.Chapters.OrderByDescending(x => x.UpdatedAt).Take(24).ToList();
            ViewBag.FullStories = context.Stories.Where(x => x.Status == 1).ToList();
            ViewBag.ListNewChapters = listNewChapters;
            return View();
        }
    }
}
