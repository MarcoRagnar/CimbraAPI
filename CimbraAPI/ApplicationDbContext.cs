﻿using CimbraAPI.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CimbraAPI
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet< Genero > Generos { get; set; }
        public DbSet< Actor> Actores { get; set; }
    }
}
