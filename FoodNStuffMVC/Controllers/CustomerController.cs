﻿using FoodNStuffMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodNStuffMVC.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Customer
        public ActionResult Index()
        {
            return View(_db.Customers.ToList());
        }
        // GET: Customer/Create  ---  This will create the View 
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost] // Request Method
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _db.Customers.Add(customer);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }




    }
}