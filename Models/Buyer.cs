using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace EmartApplication.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Please Enter Mobile Number")]
        public string Phno { get; set; }
        [EmailAddress(ErrorMessage = "Please Enter Email Address")]
       // [ValidateDomain(allowdomain: "@gmail.com")]
        [Required]
        [Remote(action:"IsExist",controller:"Buyers")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Password ")]
        [RegularExpression("[a-z0-9]{6,8}", ErrorMessage = "Password is required")]
        [DataType("password")]
        public string Pwd { get; set; }
        [Compare("Pwd", ErrorMessage = "password Mismatch")]
        [DataType("password")]
        public string Cpwd { get; set; }
       public Buyer(int id,string name,string phno,string email,string pwd,string cpwd)
        {
            this.Id = id;
            this.Name = name;
            this.Phno = phno;
            this.Email = email;
            this.Pwd = pwd;
            this.Cpwd = cpwd;
        }
        public Buyer()
        {

        }
    }
}
