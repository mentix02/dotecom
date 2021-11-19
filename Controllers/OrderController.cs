using ecom.Data;
using ecom.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace ecom.Controllers
{
    public class OrderController : Controller
    {

        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public OrderController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult List()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var orders = 
                dbContext.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.ProductVariant)
                .ThenInclude(pv => pv.Product)
                .Where(o => o.ApplicationUserId == userId)
                .OrderByDescending(o => o.Timestamp)
                .ToList();
            return View(orders);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Add()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var cart = dbContext.Carts
                .Include(c => c.Items)
                .ThenInclude(i => i.ProductVariant)
                .FirstOrDefault(c => c.ApplicationUserId == userId);
            return View(cart);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add([Bind("Country","City","Street","PostalCode")] Address address)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            
            var order = new Order { 
                Address = address,
                Timestamp = DateTime.Now,
                ApplicationUserId = userId,
                OrderItems = new List<OrderItem>()
            };
            
            var cart = dbContext.Carts
                .Include(c => c.Items)
                .ThenInclude(i => i.ProductVariant)
                .FirstOrDefault(c => c.ApplicationUserId == userId);

            foreach (var cartItem in cart.Items)
            {
                order.OrderItems.Add(new OrderItem { ProductVariantId = cartItem.ProductVariantId });
            }
            cart.Items.Clear();
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(List));
        }
    }
}
