using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiDemo.Models
{
    public class ApiUser
    {
        public int id { get; set; }
        public string  ApiUserName { get; set; }
        public string ApiUserAddress { get; set; }
        public string ApiUserEmailId { get; set; }
        public string ApiUserPassword { get; set; }
    }
}