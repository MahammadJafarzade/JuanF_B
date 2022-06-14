using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Sliders> Sliders { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<ProductColor> ProdutColor { get; set; }
        public DbSet<ProductImages> productimages { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Features> Features { get; set; }






    }
}
