using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace UmbracoBlazor.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {   
            //List<IPublishedContent> publishedContentItem = Umbraco.ContentAtRoot().ToList();

            //[HttpGet]
            //[HttpOptions]
            //public JsonResult<List<LocationArticleViewModel>> GetAllLocationArticles()
            //{
            //    List<IPublishedContent> publishedContentItem = Umbraco.ContentAtRoot().ToList();

            //    var articleList = new List<LocationArticleViewModel>();

            //    foreach (IPublishedContent item in publishedContentItem)
            //    {
            //        foreach (IPublishedContent locationItem in item.Children)
            //        {
            //            var aa = locationItem.Name;
            //            if (locationItem.ContentType.Alias == "location")
            //            {
            //                foreach (IPublishedContent containerItem in locationItem.Children)
            //                {
            //                    if (containerItem.ContentType.Alias == "pages")
            //                    {
            //                        foreach (IPublishedContent page in containerItem.Children)
            //                        {
            //                            try
            //                            {

            //                                var text = Regex.Replace(page.GetProperty("text").GetValue().ToString(), "<.*?>", String.Empty);

            //                                if (text.Length > 200)
            //                                    text = text.Substring(0, 200) + "...";

            //                                var d = (DateTime)page.GetProperty("Date").GetValue();

            //                                var article = new LocationArticleViewModel()
            //                                {
            //                                    Id = page.Id,
            //                                    Key = page.Key.ToString(),
            //                                    Name = page.Name,
            //                                    Title = page.GetProperty("title").GetValue().ToString(),
            //                                    Location = locationItem.Name,
            //                                    Abstract = page.GetProperty("abstract").GetValue().ToString(),
            //                                    Url = FullUrl(page.Url),
            //                                    ImageUrl = ImageUrl((UmbracoModels.Image)page.GetProperty("mainImage").GetValue())
            //                                };

            //                                if (d.Year != 1)
            //                                    article.Date = d;

            //                                articleList.Add(article);
            //                            }
            //                            catch (Exception ex)
            //                            {
            //                                articleList.Add(new LocationArticleViewModel()
            //                                {
            //                                    Id = locationItem.Id,
            //                                    Name = locationItem.Name,
            //                                    Title = ex.Message
            //                                });
            //                            }
            //                        }

            //                        articleList = articleList.OrderByDescending(x => x.Date).ToList();
            //                    }
            //                }

            //            }
            //        }
            //    }

            //    List<LocationArticleViewModel> result = articleList.OrderByDescending(x => x.Date).ToList();

            //    //Locations = Locations.OrderBy(x => x.Articles.Select(p=>p.Date)).ToList();

            //    return Json(result);
            //}

            return View();
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
