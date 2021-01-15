using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWebServer.Models
{
    public class TestViewModel
    {
        [Required] // attribute
        public string TestName { get; set; }

        [Required]
        [StringLength(10)] // attribute
        public string TestStreet { get; set; }

    }
}
