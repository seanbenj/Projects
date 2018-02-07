﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BloggersAppTutorial.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index(int? articleId, bool? forceReload)
        {
            MvcApplication.mainBlog.GetAllBlogArticles(forceReload);
            ViewBag.Articles = (List<HangingTree.Models.BlogArticle>)MvcApplication.mainBlog;
            // WARNING!!! Insure that ViewBag.BlogPath terminates with a slash /
            ViewBag.BlogPath = "../blogFiles/";
            if (articleId != null)
            {
                ViewBag.currentArticle = articleId;
            }
            return View();
        }


        // GET: Blog/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Blog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blog/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Blog/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Blog/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Blog/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Blog/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
