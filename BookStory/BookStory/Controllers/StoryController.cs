using BookStory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace BookStory.Controllers
{
    public class StoryController : Controller
    {
        readonly StoryDBContext context = new();

        public IActionResult Detail(int id, int? page)
        {
            Story s = null;
            s = context.Stories.FirstOrDefault(x => x.Sid == id);
            Author author = null;
            author = context.Authors.FirstOrDefault(x => x.Aid == context.StoriesAuthors.FirstOrDefault(s => s.Sid == id).Aid);
            ViewBag.Author = author;
            List<Category> categoriesOfStory = new();
            List<Category> listAllCategories = context.Categories.ToList();
            List<StoriesCategory> storiesCategories = null;
            storiesCategories = context.StoriesCategories.Where(x => x.Sid == id).ToList();
            foreach (StoriesCategory sc in storiesCategories)
            {
                foreach (Category c in context.Categories.ToList())
                {
                    if (sc.Cid == c.Cid)
                    {
                        categoriesOfStory.Add(c);
                    }
                }
            }
            List<Chapter> chapters = context.Chapters.Where(x => x.Sid == id).ToList();
            ViewBag.Categories = categoriesOfStory;
            ViewBag.AllCategories = listAllCategories;
            ViewBag.Story = s;
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var chaptersPage = chapters.ToList();
            return View(chaptersPage.ToPagedList(pageNumber, pageSize));
        }

        public IActionResult Content(int id, int page)
        {
            Chapter c = null;
            List<Category> listAllCategories = context.Categories.ToList();
            c = context.Chapters.FirstOrDefault(x => x.Sid == id && x.Chapnumber == page.ToString());
            ViewBag.AllCategories = listAllCategories;
            ViewBag.AllChapters = context.Chapters.Where(x => x.Sid == id).ToList();
            return View(c);
        }
    }
}
