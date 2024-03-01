using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Net.Http.Headers;
using System.Net.Http;
using BusinessObject.DTO;
using System.Text.Json;

namespace eStoreWebClient.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly HttpClient client = null;
        private string productApiUrl = "";
        public OrdersController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            productApiUrl = "http://localhost:33147/api/Orders";
        }

        private string CurrentUser()
        {
            string memId = "";
            var user = HttpContext.User;
            if (user?.Identity != null && user.Identity.IsAuthenticated)
            {
                var claimsIdentity = user.Identity as ClaimsIdentity;
                memId = claimsIdentity.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            }
            return memId;
        }
        public async Task<IActionResult> Index()
        {
            ViewData["MemberId"] = CurrentUser();
            return View();
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            return View();
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["MemberId"] = CurrentUser();
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,MemberId,OrderDate,RequiredDate,ShippedDate,Freight")] Order order)
        {
            return View();
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var response = await client.GetAsync($"{productApiUrl}/{id}");
            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var memberString = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var product = JsonSerializer.Deserialize<OrderDTO>(memberString, options);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,MemberId,OrderDate,RequiredDate,ShippedDate,Freight")] Order order)
        {
            return View();
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            return View();
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            return View();
        }

    }
}
