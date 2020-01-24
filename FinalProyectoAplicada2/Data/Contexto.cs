using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalProyectoAplicada2.Data
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Server=DESKTOP-B3FBQ4F;Database=Aplicada2ProyectoFinalRecursosHumanosDB;Trusted_Connection=true"));
        }

        public DbSet<Employees> Employees { get; set; }

    }
}
