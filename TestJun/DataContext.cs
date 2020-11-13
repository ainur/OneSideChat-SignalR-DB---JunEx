using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestJun.Models;

namespace TestJun
{
    public class DataContext : DbContext
    {
        
        
            public DataContext(DbContextOptions<DataContext> options) : base(options)
            {

            }
  
            public DbSet<Message> Messages { get; set; }
        
    }
}
