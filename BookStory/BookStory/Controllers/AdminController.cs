using BookStory.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using X.PagedList;
using Microsoft.AspNetCore.Http;
using System.Web;
using Newtonsoft.Json;

namespace BookStory.Controllers
{
    public class AdminController : Controller
    {
        readonly StoryDBContext context = new();

        public IActionResult ListStory(int? id)
        {
            try
            {
                if (VerifyAdmin() == 1)
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
                    if (id == null) id = 1;
                    int pageSize = 20;
                    int pageNumber = (id ?? 1);
                    stories.Reverse();
                    var storiesPage = stories;
                    return View(storiesPage.ToPagedList(pageNumber, pageSize));
                }
                else if (VerifyAdmin() == 0)
                {
                    return RedirectToAction("Login", "User");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Message", "Error");
            }
        }

        public IActionResult ListUser(int? id)
        {
            try
            {
                if (VerifyAdmin()==1)
                {
                    List<Story> stories = context.Stories.ToList();
                    List<User> users = context.Users.ToList();
                    int totalView = 0;
                    foreach (Story story in stories)
                    {
                        totalView += (int)story.View;
                    }
                    ViewBag.TotalView = totalView;
                    ViewBag.TotalStory = stories.Count;
                    ViewBag.TotalUser = context.Users.ToList().Count;
                    _ = context.Chapters.ToList();
                    if (id == null) id = 1;
                    int pageSize = 20;
                    int pageNumber = (id ?? 1);
                    users.Reverse();
                    return View(users.ToPagedList(pageNumber, pageSize));
                }
                else if (VerifyAdmin() == 2)
                {
                    return RedirectToAction("Login", "User");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Message", "Error");
            }
        }

        public IActionResult ListChapter(int? id)
        {
            try
            {
                if (VerifyAdmin()==1)
                {
                    List<Story> stories = context.Stories.ToList();
                    List<Chapter> chapters = context.Chapters.OrderBy(x => x.Name).ToList();
                    int totalView = 0;
                    foreach (Story story in stories)
                    {
                        totalView += (int)story.View;
                    }
                    ViewBag.TotalView = totalView;
                    ViewBag.TotalStory = stories.Count;
                    ViewBag.TotalUser = context.Users.ToList().Count;
                    _ = context.Chapters.ToList();
                    if (id == null) id = 1;
                    int pageSize = 20;
                    int pageNumber = (id ?? 1);
                    return View(chapters.ToPagedList(pageNumber, pageSize));
                }
                else if (VerifyAdmin() == 2)
                {
                    return RedirectToAction("Login", "User");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Message", "Error");
            }

        }

        [HttpPost]
        public IActionResult AddCategory(string category)
        {
            try
            {
                if (VerifyAdmin() == 1)
                {
                    Category c = new()
                    {
                        Title = category
                    };
                    context.Add<Category>(c);
                    context.SaveChanges();
                    return RedirectToAction("ListStory", "Admin");
                }
                else if (VerifyAdmin() == 2)
                {
                    return RedirectToAction("Login", "User");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Message", "Error");
            }
        }

        [HttpPost]
        public IActionResult EditCategory(int cid, string title)
        {
            Category c = context.Categories.FirstOrDefault(x => x.Cid == cid);
            c.Title = title;
            context.SaveChanges();
            return RedirectToAction("ListStory", "Admin");
        }

        [HttpPost]
        public IActionResult DeleteStory(int storyid)
        {
            try
            {
                List<StoriesAuthor> storiesAuthors = context.StoriesAuthors.Where(x => x.Sid == storyid).ToList();
                List<StoriesCategory> storiesCategories = context.StoriesCategories.Where(x => x.Sid == storyid).ToList();
                List<Chapter> chapters = context.Chapters.Where(x => x.Sid == storyid).ToList();
                Story s = context.Stories.FirstOrDefault(x => x.Sid == storyid);
                context.StoriesAuthors.RemoveRange(storiesAuthors);
                context.StoriesCategories.RemoveRange(storiesCategories);
                context.Chapters.RemoveRange(chapters);
                context.Remove(s);
                context.SaveChanges();
                return RedirectToAction("ListStory", "Admin");
            } catch (Exception ex)
            {
                return RedirectToAction("Message", "Error");
            }
        }

        [HttpPost]
        public IActionResult DeleteChapter(int chapterid)
        {
            try
            {
                List<Reading> readings = context.Readings.Where(x => x.Ctid == chapterid).ToList();
                Chapter chapter = context.Chapters.FirstOrDefault(x => x.Ctid == chapterid);
                context.RemoveRange(readings);
                context.Remove(chapter);
                context.SaveChanges();
                return RedirectToAction("ListChapter", "Admin");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Message", "Error");
            }
        }

        [HttpPost]
        public IActionResult AddAuthor(string author)
        {
            try
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
            catch (Exception ex)
            {
                return RedirectToAction("Message", "Error");
            }
            
        }

        [HttpPost]
        public IActionResult EditAuthor(int aid, string authorName)
        {
            Author a = context.Authors.FirstOrDefault(x => x.Aid == aid);
            a.Name = authorName;
            context.SaveChanges();
            return RedirectToAction("ListStory", "Admin");
        }

        [HttpPost]
        public IActionResult AddStory(string name, int[] categories, int author, int status, string source, IFormFile image, string keyword, string description)
        {
            try
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "StoriesImage", image.FileName);
                using (var file = new FileStream(fullPath, FileMode.Create))
                {
                    image.CopyTo(file);
                }
                Story story = new()
                {
                    Name = name,
                    Status = status,
                    Source = source,
                    View = 0,
                    Image = image.FileName,
                    Keyword = keyword,
                    Description = description,
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                };
                _ = context.Add(story);
                _ = context.SaveChanges();
                for (int i = 0; i < categories.Length; i++)
                {
                    StoriesCategory sc = new()
                    {
                        Scid = context.StoriesCategories.OrderByDescending(x => x.Scid).FirstOrDefault().Scid + 1,
                        Cid = categories[i],
                        Sid = context.Stories.FirstOrDefault(x => x.Name.Equals(story.Name)).Sid
                    };
                    _ = context.Add(sc);
                    _ = context.SaveChanges();
                }
                StoriesAuthor sa = new()
                {
                    Said = context.StoriesAuthors.OrderByDescending(x => x.Said).FirstOrDefault().Said + 1,
                    Sid = context.Stories.FirstOrDefault(x => x.Name.Equals(story.Name)).Sid,
                    Aid = author
                };
                _ = context.Add(sa);
                _ = context.SaveChanges();
                return RedirectToAction("ListStory", "Admin");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Message", "Error");
            }
        }

        [HttpPost]
        public IActionResult EditStory(int sid, string name, int[] categories, int author, int status, string source, IFormFile image, string keyword, string description)
        {
            
            try
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "StoriesImage", image.FileName);
                using (var file = new FileStream(fullPath, FileMode.Create))
                {
                    image.CopyTo(file);
                }
                var entity = context.Stories.FirstOrDefault(x => x.Sid == sid);
                entity.Name = name;
                entity.Source = source;
                entity.Image = image.FileName;
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
            catch (Exception ex)
            {
                return RedirectToAction("Message", "Error");
            }
        }

        [HttpPost]
        public IActionResult EditChapter(int ctid, string chaptername, string chapternumber, string chaptersubname, string chaptercontent)
        {
            try
            {
                var entity = context.Chapters.FirstOrDefault(x => x.Ctid == ctid);
                entity.Name = chaptername;
                entity.Subname = chaptersubname;
                entity.Chapnumber = chapternumber;
                entity.Content = chaptercontent;
                entity.UpdatedAt = DateTime.Now;
                context.Entry(entity).CurrentValues.SetValues(entity);
                context.SaveChanges();
                return RedirectToAction("ListChapter", "Admin");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Message", "Error");
            }
            
        }

        [HttpPost]
        public IActionResult AddChapter(int sid, string chaptername, string chapternumber, string chaptersubname, string chaptercontent)
        {
            try
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
            catch (Exception ex)
            {
                return RedirectToAction("Message", "Error");
            }
        }

        [HttpPost]
        public JsonResult GetStory(int storyid)
        {
            try
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
            catch (Exception ex)
            {

            }
            return null;
        }

        [HttpPost]
        public JsonResult GetChapter(int sid)
        {
            try
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
                    name = s.Name,
                    subname = s.Subname,
                    content = s.Content,
                });
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        [HttpPost]
        public JsonResult GetChapterByCtid(int ctid)
        {
            try
            {
                Chapter s = context.Chapters.FirstOrDefault(x => x.Ctid == ctid);
                return Json(new
                {
                    chapnumber = s.Chapnumber,
                    name = s.Name,
                    subname = s.Subname,
                    content = s.Content,
                });
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public int VerifyAdmin()
        {
            User u = null;
            string json = HttpContext.Session.GetString("user");
            if (json != null) u = JsonConvert.DeserializeObject<User>(json);
            if(u != null)
            {
                if (u.Role == 1)
                {
                    return 1;
                }
                else if (u.Role == 2)
                {
                    return 2;
                }
            } 
            return 0;
        }
    }
}
