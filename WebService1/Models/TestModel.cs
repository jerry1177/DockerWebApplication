using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebService1.Models
{
    public class TestModel
    {
        
        [Required] // make sure this field is not null attribute
        [StringLength(20)]
        public string TestName { get; set; }

       
        [Required]
        [StringLength(10)] // make sure the string is no longer than 10 characters attribute
        public string TestStreet { get; set; }
    }
}
