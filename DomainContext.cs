using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PixelBucket.Models
{
    public class DomainContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public DomainContext(DbContextOptions<DomainContext> options)
            : base(options) { }

        public Microsoft.EntityFrameworkCore.DbSet<Item> Items {get; set;}
    }
}
