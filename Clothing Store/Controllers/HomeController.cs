using Clothing_Store.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clothing_Store.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = GetProducts();

            return View(products);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Products()
        {
            var products = GetProducts();

            return View(products);
        }

        public IActionResult Address()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Silk Evening Dress",
                    Category = "Dresses",
                    Price = 185,
                    ImageUrl = "/images/dress1.jpg",
                    Description = "Elegant silk dress designed for timeless evening style."
                },

                new Product
                {
                    Id = 2,
                    Name = "Classic Tailored Blazer",
                    Category = "Blazers",
                    Price = 220,
                    ImageUrl = "/images/blazer.jpg",
                    Description = "Minimalist tailored blazer with a refined silhouette."
                },

                new Product
                {
                    Id = 3,
                    Name = "Minimal Long Coat",
                    Category = "Outerwear",
                    Price = 290,
                    ImageUrl = "/images/coat.jpg",
                    Description = "A sophisticated long coat for an effortlessly elegant look."
                },

                new Product
                {
                    Id = 4,
                    Name = "Satin Evening Set",
                    Category = "Sets",
                    Price = 245,
                    ImageUrl = "/images/set.jpg",
                    Description = "Refined satin set created for modern elegance."
                },

                new Product
                {
                    Id = 5,
                    Name = "Classic Black Dress",
                    Category = "Dresses",
                    Price = 175,
                    ImageUrl = "/images/blackdress.jpg",
                    Description = "A timeless black dress with a clean minimalist design."
                },

                new Product
                {
                    Id = 6,
                    Name = "Luxury Cream Blouse",
                    Category = "Tops",
                    Price = 125,
                    ImageUrl = "/images/blouse.jpg",
                    Description = "Soft cream blouse with a sophisticated minimalist finish."
                }
            };
        }
    }
}