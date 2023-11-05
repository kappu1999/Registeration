using Registeration.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Registeration.Entities
{
    public class Contextdb : DbContext
    {

        public Contextdb() : base("name=UserdbConnectionString")
        {

        }
        public DbSet<TeamMembers> teamMembers { get; set; }

        public DbSet<Files> files { get; set; }
    }
}