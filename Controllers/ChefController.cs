using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using chefs_dishes.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace chefs_dishes.Controllers
{
    public class ChefController : Controller
    {
      //injecting context service
      private ChefContext dbContext;
      public ChefController(ChefContext context)
      {
          dbContext = context;
      }

      [HttpGet("")]
      public IActionResult Index()
      {
          return View("Index");
      }

      [HttpGet("new")]
      public IActionResult ChefNew(){
        return View("ChefNew");
      }

      [HttpPost("addchef")]
      public IActionResult AddChef(Chef chef){
        if(ModelState.IsValid){
        //   string dob = chef.DOB.ToString("dd/MM/yyyy");
        //   string now = DateTime.Now.ToString("dd/MM/yyyy");
        //   if(chef.DOB < DateTime.Now){
            dbContext.Add(chef);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
          }
          // else{
          //   ModelState.AddModelError("DOB", "Date of birth must be in the past");
          //   return View("ChefNew");
          // }
        // }
        else{
          return View("ChefNew");
        }
      }

      [HttpGet("dishes")]
      public IActionResult Dishes(){
        List<Dish> DishAndChef = dbContext.dishes.Include(dish => dish.Creator).ToList(); //make sure to turn this into a List. Can use ViewBag as well.
        return View("Dishes", DishAndChef);
      }

      [HttpGet("dishes/new")]
      public IActionResult AddDish(){
        ViewBag.allchefs = dbContext.chefs;
        return View("DishNew");
      }

      [HttpPost("ProcessDish")]
      public IActionResult ProcessDish(Dish dish){
        if(ModelState.IsValid){
          dbContext.Add(dish);
          dbContext.SaveChanges();
          return RedirectToAction("Dishes");
        }
        else{
          ViewBag.allchefs = dbContext.chefs; //prepopulate allchefs will help save the NullReference error: foreach(var dish in @ViewBag.allchefs){
          return View("DishNew");
        }
      }

      [HttpGet("chefs")]
      public IActionResult Chefs(){
        ViewBag.ChefwithDish = dbContext.chefs.Include(c => c.CreatedDishes); //make sure to turn this into a List
        
        foreach(var chef in ViewBag.ChefwithDish){
          var today = DateTime.Today;
          ViewBag.age = today.Year - chef.DOB.Year;
          // ViewBag.DishCount = chef.CreatedDishes.Count;
        }
        return View("Chefs");
      }
    }
}
