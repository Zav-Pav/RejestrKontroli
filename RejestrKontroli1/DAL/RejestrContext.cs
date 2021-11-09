using RejestrKontroli1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RejestrKontroli1.DAL
{
    public class RejestrContext:DbContext
    {
       
            public RejestrContext() : base("connectionstring")
            {


            }
            public DbSet<Rejestr> Rejestr { get; set; }

        
    }
}