using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Lib.Data.Database
{
    public partial class FerreTodosContext : Database.FerreTodo.FerreTodoContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlServer("Data Source=205.209.114.122;Initial Catalog=FerreTodoElArabito;Persist Security Info=True;User ID=ElArabito;Password=?c5ta083L123$;TrustServerCertificate=True");
            }
        }
    }
}
