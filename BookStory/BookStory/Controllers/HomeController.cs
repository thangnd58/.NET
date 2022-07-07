using BookStory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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
                stories = context.Stories.OrderByDescending(s => s.Sid).Take(16).ToList();
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
            ViewBag.Stories = stories;
            ViewBag.CurrentId = id;
            Dictionary<Chapter, List<Category>> listNewChapters = new();
            foreach (Chapter c in context.Chapters.OrderByDescending(x => x.UpdatedAt).Take(24).ToList())
            {
                listNewChapters.Add(c, GetCategoriesBySid(c.Sid));
            }
            ViewBag.FullStories = context.Stories.Where(x => x.Status == 1).OrderByDescending(s => s.Sid).Take(12).ToList();
            _ = context.Chapters.ToList();
            ViewBag.ListNewChapters = listNewChapters;
            User u = null;
            string json = HttpContext.Session.GetString("user");
            if (json != null)
            {
                u = JsonConvert.DeserializeObject<User>(json);
                List<Chapter> SaveChapters = context.Chapters.OrderByDescending(s => s.Sid).Where(x => x.Readings.Where(r => r.Ctid == x.Ctid && r.Uid == u.Uid).Any()).Take(16).ToList();
                ViewBag.SaveChapters = SaveChapters;
            }
            return View();
        }

        public List<Category> GetCategoriesBySid(int sid)
        {
            List<Category> categories = new();
            categories = context.Categories.Where(x => x.StoriesCategories.Where(s => s.Sid == sid).Any()).ToList();
            return categories;
        }
    }
}
