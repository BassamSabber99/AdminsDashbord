using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Admins.Models
{
    public class Employee
    {
        public byte id  { get; set; }
        [Required]
        public int hrCode { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string name { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string image { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int phone { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string address { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string title { get; set; }
        public Department Department { get; set; }
        public byte deparetmentId { get; set; }
    }
}