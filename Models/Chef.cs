using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace chefs_dishes.Models
{
  public class Chef
  {
    [Key]
    public int ChefId {get;set;}

    [Required]
    [MinLength(2, ErrorMessage = "First Name must be at least 2 characters long")]
    public string FirstName {get; set;}

    [Required]
    [MinLength(2, ErrorMessage = "Last Name must be at least 2 characters long")]
    public string LastName {get; set;}

    // [Required, DateBeforeNow(ErrorMessage="Date must be in the past")]
    [Required]
    public DateTime DOB {get;set;}

    [NotMapped]
    public int Age {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
    public List<Dish> CreatedDishes {get;set;}
    public Chef(){

    }
    public Chef(string fname, string lname, int age, DateTime dob){
      FirstName = fname;
      LastName = lname;
      Age = age;
      DOB = dob;
    }
  }
}