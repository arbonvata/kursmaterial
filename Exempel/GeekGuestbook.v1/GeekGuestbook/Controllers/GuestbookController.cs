﻿using System;
using System.Linq;
using System.Web.Mvc;
using GeekGuestbook.Models;
using GeekGuestbook.Models.DataModels;

namespace GeekGuestbook.Controllers
{
    public class GuestbookController : Controller
    {
        GeekGuestbookEntities _entities = new GeekGuestbookEntities();

        //
        // GET: /Guestbook/

        public ActionResult Index()
        {
            var messages = _entities.Messages.ToList();

            return View(messages);
        }

        //
        // GET: /Guestbook/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Guestbook/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Message message)
        {
            message.Created = DateTime.Now;

            _entities.Messages.Add(message);
            _entities.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _entities.Dispose();
            base.Dispose(disposing);
        }
    }
}
