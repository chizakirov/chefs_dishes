using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace chefs_dishes.Models
{
  public class Dish
  {
    [Key]
    public int DishId{ get; set; }

    [Required]
    public string DishName {get; set;}

    [Required]
    [Range(1, double.MaxValue, ErrorMessage = "Calories must be a positive number")]
    public int Calories{get; set;}

    [Required]
    public int Tastiness{get; set;}

    [Required]
    public string Desc{get; set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    [ForeignKey("ChefId")]
    public int ChefId {get;set;}
    public Chef Creator {get;set;}

    public Dish(){
    }
    public Dish(string dishname, int calories, int tastiness, string desc){
      DishName = dishname;
      Calories = calories; 
      Tastiness = tastiness;
      Desc = desc;
    }
  }
}