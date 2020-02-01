using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace EmartApplication.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Please Enter Mobile Number")]
        public string Phno { get; set; }

        public string CompName { get; set; }
        public string Gstin { get; set; }
        [EmailAddress(ErrorMessage = "Please Enter Email Address")]
        [Required]
        [Remote(action: "IsExist", controller: "Sellers")]
        //[ValidateDomain(allowdomain:"@gmail.com")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Password ")]
        [RegularExpression("[a-z0-9]{6,8}",ErrorMessage ="Password is required")]
     
        public string Pwd { get; set; }
        [Compare("Pwd", ErrorMessage = "password Mismatch")]
        public string Cpwd { get; set; }
        //public IFormFile PhotoPath { get; set; }
        public Seller(int id,string name,string phno,string compname,string gstin,string email,string pwd,string cpwd)
        {
            this.Id = id;
            this.Name = name;
            this.CompName = compname;
            this.Gstin = gstin;
            this.Email = email;
            this.Pwd = pwd;
            this.Cpwd = cpwd;
        }
       public Seller()
        {

        }


    }
}
