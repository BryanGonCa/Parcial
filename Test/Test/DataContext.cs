﻿using System.Data.Entity;

namespace Test
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Test.Models.Student> Students { get; set; }
    }
}