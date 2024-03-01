﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using System.Net.Http.Headers;
using System.Net.Http;
using BusinessObject.DTO;
using System.Text.Json;

namespace eStoreWebClient.Controllers
{
    public class OrderDetailsController : Controller
    {

        private readonly HttpClient client = null;
        private string productApiUrl = "";
        public OrderDetailsController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            productApiUrl = "http://localhost:33147/api/OrderDetails";
        }

        // GET: OrderDetails
        public async Task<IActionResult> Index(int id)
        {
            ViewData["OrderId"] = id;
            return View();
        }

        // GET: OrderDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
           

            return View();
        }

        // GET: OrderDetails/Create
        public IActionResult Create(int id)
        {
            ViewData["OrderId"] = id;
            return View();
        }

        // POST: OrderDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,ProductId,UnitPrice,Quantity,Discount")] OrderDetail orderDetail)
        {
            return View();
        }

        // GET: OrderDetails/Edit/5
        public async Task<IActionResult> Edit(int? oid, int pid)
        {
            var response = await client.GetAsync($"{productApiUrl}/get-id?oid={oid}&pid={pid}");
            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var memberString = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var product = JsonSerializer.Deserialize<OrderDetailDTO>(memberString, options);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["OrderId"] = oid;
            return View(product);
        }

        // POST: OrderDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,ProductId,UnitPrice,Quantity,Discount")] OrderDetail orderDetail)
        {
            return View();
        }

        // GET: OrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            return View();
        }

        // POST: OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            return View();
        }
    }
}
