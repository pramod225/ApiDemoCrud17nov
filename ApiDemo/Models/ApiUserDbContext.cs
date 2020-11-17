using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiDemo.Models
{
    public class ApiUserDbContext :DbContext
    {
        public DbSet<ApiUser> apiUsers  { get; set; }
    }
}