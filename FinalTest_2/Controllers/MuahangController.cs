using kiemtra.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FinalTest_2.Models;

namespace FinalTest_2.Controllers
{
    public class MuahangController : Controller
    {
        public static List<HomeProduct> products = new List<HomeProduct>();
        public IActionResult Sanpham(bool? check = false)
        {
            if ((bool)check)
            {
                products.Clear();
            }
            else
            {
                return View(products.ToList());
            }
            return View();
        }
        [HttpPost]
        public IActionResult Sanpham(string tensanpham, int soluong, int dongia, double giamgia)
        {
            var homeProduct = new HomeProduct(tensanpham, soluong, dongia, giamgia);
            products.Add(homeProduct);
            return View(products);
        }

        public IActionResult RemoveProduct(int position)
        {
            products.RemoveAt(position - 1);
            return RedirectToAction("Sanpham", "Muahang");
        }
    }
}

