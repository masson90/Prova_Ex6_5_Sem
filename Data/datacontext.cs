using Microsoft.EntityFrameworkCore;
using Prova_Ex6_5_Sem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova_Ex6_5_Sem.Data
{
    public class datacontext : DbContext
    {

        public datacontext(DbContextOptions<datacontext> options):base(options)
        {
    
        }

        public DbSet<Biblioteca> Bibliotecas { get; set; }

    }
}
