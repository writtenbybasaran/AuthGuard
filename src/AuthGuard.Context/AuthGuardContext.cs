using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthGuard.Model;
using Microsoft.EntityFrameworkCore;

namespace AuthGuard.Context
{
    public class AuthGuardContext : DbContext
    {
        public AuthGuardContext(DbContextOptions<AuthGuardContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
