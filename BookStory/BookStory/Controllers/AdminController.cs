using BookStory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BookStory.Controllers
{
    public class AdminController : Controller
    {
        readonly StoryDBContext context = new();

        public IActionResult ListStory()
        {
            List<Story> stories = context.Stories.ToList();
            ViewBag.Stories = stories;
            int totalView = 0;
            foreach (Story story in stories)
            {
                totalView += (int)story.View;
            }
            ViewBag.TotalView = totalView;
            ViewBag.TotalStory = stories.Count;
            ViewBag.TotalUser = context.Users.ToList().Count;
            ViewBag.Authors = context.Authors.ToList();
            ViewBag.Categories = context.Categories.ToList();
            _ = context.Chapters.ToList();
            return View();
        }

        public IActionResult ListUser()
        {
            List<Story> stories = context.Stories.ToList();
            List<User> users = context.Users.ToList();
            ViewBag.Users = users;
            int totalView = 0;
            foreach (Story story in stories)
            {
                totalView += (int)story.View;
            }
            ViewBag.TotalView = totalView;
            ViewBag.TotalStory = stories.Count;
            ViewBag.TotalUser = context.Users.ToList().Count;
            _ = context.Chapters.ToList();
            return View();
        }

        public IActionResult ListChapter()
        {
            List<Story> stories = context.Stories.ToList();
            List<Chapter> chapters = context.Chapters.ToList();
            ViewBag.Chapters = chapters;
            int totalView = 0;
            foreach (Story story in stories)
            {
                totalView += (int)story.View;
            }
            ViewBag.TotalView = totalView;
            ViewBag.TotalStory = stories.Count;
            ViewBag.TotalUser = context.Users.ToList().Count;
            _ = context.Chapters.ToList();
            return View();
        }

        //public IActionResult Add()
        //{
        //    List<Story> stories = context.Stories.ToList();
        //    int totalView = 0;
        //    foreach (Story story in stories)
        //    {
        //        totalView += (int)story.View;
        //    }
        //    ViewBag.TotalView = totalView;
        //    ViewBag.TotalStory = stories.Count;
        //    ViewBag.TotalUser = context.Users.ToList().Count;
        //    ViewBag.Authors = context.Authors.ToList();
        //    ViewBag.Categories = context.Categories.ToList();
        //    ViewBag.Stories = stories.OrderByDescending(x => x.Sid);
        //    _ = context.Chapters.ToList();
        //    return View();
        //}

        [HttpPost]
        public IActionResult AddCategory(string category)
        {
            Category c = new()
            {
                Title = category
            };
            context.Add<Category>(c);
            context.SaveChanges();
            return RedirectToAction("ListStory", "Admin");
        }

        [HttpPost]
        public IActionResult AddAuthor(string author)
        {
            Author a = new()
            {
                Aid = context.Authors.ToList().Count + 1,
                Name = author
            };
            context.Add<Author>(a);
            context.SaveChanges();
            return RedirectToAction("ListStory", "Admin");
        }


        [HttpPost]
        public IActionResult AddStory(string name, int[] categories, int author, int status, string source, string image, string keyword, string description)
        {
            Story story = new()
            {
                Name = name,
                Status = status,
                Source = source,
                View = 0,
                Image = image,
                Keyword = keyword,
                Description = description,
                CreatedAt = System.DateTime.Now,
                UpdatedAt = System.DateTime.Now
            };
            context.Add<Story>(story);
            context.SaveChanges();
            for (int i = 0; i < categories.Length; i++)
            {
                StoriesCategory sc = new()
                {
                    Scid = context.StoriesCategories.OrderByDescending(x => x.Scid).FirstOrDefault().Scid + 1,
                    Cid = categories[i],
                    Sid = context.Stories.FirstOrDefault(x => x.Name.Equals(story.Name)).Sid
                };
                context.Add<StoriesCategory>(sc);
                context.SaveChanges();
            }
            StoriesAuthor sa = new()
            {
                Said = context.StoriesAuthors.OrderByDescending(x => x.Said).FirstOrDefault().Said + 1,
                Sid = context.Stories.FirstOrDefault(x => x.Name.Equals(story.Name)).Sid,
                Aid = author
            };
            context.Add<StoriesAuthor>(sa);
            context.SaveChanges();
            return RedirectToAction("ListStory", "Admin");
        }

        [HttpPost]
        public IActionResult EditStory(int sid, string name, int[] categories, int author, int status, string source, string image, string keyword, string description)
        {
            var entity = context.Stories.FirstOrDefault(x => x.Sid == sid);
            entity.Name = name;
            entity.Source = source;
            entity.Image = image;
            entity.Status = status;
            entity.Keyword = keyword;
            entity.Description = description;
            entity.UpdatedAt = System.DateTime.Now;
            context.Entry(entity).CurrentValues.SetValues(entity);
            var entity1 = context.StoriesAuthors.FirstOrDefault(x => x.Sid == sid);
            entity1.Aid = author;
            context.Entry(entity1).CurrentValues.SetValues(entity1);
            context.StoriesCategories.RemoveRange(context.StoriesCategories.Where(x => x.Sid == sid).ToList());
            context.SaveChanges();
            for (int i = 0; i < categories.Length; i++)
            {
                StoriesCategory sc = new()
                {
                    Scid = context.StoriesCategories.OrderByDescending(x => x.Scid).FirstOrDefault().Scid + 1,
                    Cid = categories[i],
                    Sid = sid
                };
                context.Add<StoriesCategory>(sc);
                context.SaveChanges();
            }
            return RedirectToAction("ListStory", "Admin");
        }


        [HttpPost]
        public IActionResult AddChapter(int sid, string chaptername, string chapternumber, string chaptersubname, string chaptercontent)
        {
            Chapter c = new()
            {
                Name = chaptername,
                Subname = chaptersubname,
                Chapnumber = chapternumber,
                Content = chaptercontent,
                Sid = sid,
                CreatedAt = System.DateTime.Now,
                UpdatedAt = System.DateTime.Now
            };
            context.Add<Chapter>(c);
            context.SaveChanges();
            return RedirectToAction("ListStory", "Admin");
        }

        [HttpGet]
        public JsonResult GetStory(int storyid)
        {
            Story s = context.Stories.FirstOrDefault(x => x.Sid == storyid);
            Author a = context.Authors.FirstOrDefault(x => x.Aid == x.StoriesAuthors.FirstOrDefault(sa => sa.Sid == storyid).Aid);
            List<int> sc = context.StoriesCategories.Where(x => x.Sid == storyid).Select(x => x.Cid).ToList();
            int[] sa = sc.ToArray();
            return Json(new
            {
                sid = s.Sid,
                name = s.Name,
                status = s.Status,
                source = s.Source,
                image = s.Image,
                keyword = s.Keyword,
                description = s.Description,
                authorid = a.Aid,
                authorname = a.Name,
                listcid = sa,
            });
        }

        [HttpGet]
        public JsonResult GetChapter(int sid)
        {
            Chapter s = context.Chapters.OrderByDescending(x => x.Ctid).FirstOrDefault(x => x.Sid == sid);
            if (s == null)
            {
                s = new()
                {
                    Sid = sid,
                    Name = context.Stories.FirstOrDefault(x => x.Sid == sid).Name,
                    Chapnumber = "0",
                };
            }
            int cnumber = int.Parse(s.Chapnumber) + 1;
            return Json(new
            {
                chapnumber = cnumber,
                name = s.Name
            });
        }
    }
}
