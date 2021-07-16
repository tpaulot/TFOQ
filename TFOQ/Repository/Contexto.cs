using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TFOQ.Models;

namespace TFOQ.Repository
{
    public class Contexto: DbContext

    {
        public Contexto() : base("TfoqconnectionString")
        {

        }
        public DbSet<Mantimentos> mantimentos { get; set; }
    }
}