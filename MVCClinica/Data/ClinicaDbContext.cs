using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCClinica.Models;

namespace MVCClinica.Data
{
    public class ClinicaDbContext : DbContext
    {
        public ClinicaDbContext() : base("KeyDB") { }
        public DbSet<Medico> Medicos { get; set; }
    }
}