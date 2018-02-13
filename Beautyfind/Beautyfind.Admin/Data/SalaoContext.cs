using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Beautyfind.Admin.Models;

namespace Beautyfind.Admin.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Salao> Salao { get; set; }
        

        public Contexto(DbContextOptions<Contexto> options)
          : base(options)
        {

        }
    }
   
}
