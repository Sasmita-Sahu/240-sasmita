using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication32.Models;

namespace WebApplication32.Data
{
    public class WebApplication32Context : DbContext
    {
        public WebApplication32Context (DbContextOptions<WebApplication32Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication32.Models.Student> Student { get; set; }
    }
}
