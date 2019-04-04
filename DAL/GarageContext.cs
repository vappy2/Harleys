using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Entity;
using System.Data.Entity;
using DTO;

namespace DAL
{
    public class GarageContext:DbContext 
    {
        public DbSet<EntityHarley> Harleys { get; set;}
    }
}
