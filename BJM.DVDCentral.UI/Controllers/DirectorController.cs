﻿using BJM.DVDCentral.UI.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace BJM.DVDCentral.UI.Controllers
{
    public class DirectorController : Controller
    {
        public IActionResult Index()
        {
            return View(DirectorManager.Load());
        }
        public IActionResult Details(int id)
        {
            return View(DirectorManager.LoadById(id));
        }
        public IActionResult Create()
        {
            if (Authenticate.IsAuthenticated(HttpContext))
                return View();
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }
        [HttpPost]
        public IActionResult Create(Director director, bool rollback = false)
        {
            try
            {
                int result = DirectorManager.Insert(director, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IActionResult Edit(int id)
        {
            if (Authenticate.IsAuthenticated(HttpContext))
                return View(DirectorManager.LoadById(id));
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
            
        }
        [HttpPost]
        public IActionResult Edit(int id, Director director, bool rollback = false)
        {
            try
            {
                int result = DirectorManager.Update(director, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(director);
            }
        }
        public IActionResult Delete(int id)
        {
            return View(DirectorManager.LoadById(id));
        }
        [HttpPost]
        public IActionResult Delete(int id, Director director, bool rollback = false)
        {
            try
            {
                int result = DirectorManager.Delete(id, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(director);
            }
        }
    }
}
