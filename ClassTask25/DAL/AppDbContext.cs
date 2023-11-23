﻿using ClassTask25.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassTask25.DAL
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }

        public DbSet<Slider>Sliders { get; set; }
        public DbSet<Product>Products { get; set; }


    }
}
