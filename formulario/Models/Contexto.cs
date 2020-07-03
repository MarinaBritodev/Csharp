using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace formulario.Models
{
    public class contexto : DbContext
    {
        public DbSet<Registro> Registros { get; set; }
    }
}