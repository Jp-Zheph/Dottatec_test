using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pro_Dottatec.Models;

namespace pro_Dottatec.Data
{
    public class pro_DottatecContext : DbContext
    {
        public pro_DottatecContext (DbContextOptions<pro_DottatecContext> options)
            : base(options)
        {
        }

        public DbSet<pro_Dottatec.Models.usuario> usuario { get; set; }
        public DbSet<pro_Dottatec.Models.Login> login { get; set; }

    }
}
