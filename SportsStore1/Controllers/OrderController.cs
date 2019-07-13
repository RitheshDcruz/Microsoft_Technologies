﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore1.Models;

namespace SportsStore1.Controllers
{
    public class OrderController : Controller
    {


        private IOrderRepository repository;
        private Cart cart;

        public OrderController(IOrderRepository repo, Cart crt) {
            repository = repo;
            cart = crt;

        }

        public ViewResult List() => View(repository.Orders.Where(o => !o.Shipped));

        [HttpPost]
        public IActionResult MarkShipped(int orderID) {
            Order order = repository.Orders.FirstOrDefault(o => o.OrderID == orderID);
            if (order != null) { 
            order.Shipped = true;
                repository.SaveOrder(order);
            }

            return RedirectToAction(nameof(List));
        }


        //public ViewResult Checkout() => View(new Order());

        public IActionResult Checkout(Order order) {

            if (cart.Lines.Count() == 0) {
                ModelState.AddModelError("", "Sorry Cart empty!");

            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                // return View("Completed");
                return RedirectToAction(nameof(Completed));
            }
            else {
                return View(order);
            }

          


        }

        public ViewResult Completed() {

            cart.Clear();
            return View();

        }



    }
}