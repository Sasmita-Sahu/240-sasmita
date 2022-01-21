using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication12.Model;

namespace WebApplication12.Data
{
    public class WebApplication12Context : DbContext
    {
        public WebApplication12Context (DbContextOptions<WebApplication12Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication12.Model.Employee> Employee { get; set; }
    }
}
