using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CowinRegistration.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string AadhaarNumber { get; set; }
        [Required]
        public string ChooseFromVendor { get; set; }
    }
    public enum Vendors
    {
        Covishield
        ,Covaxine
        ,Sputnik
    }
}