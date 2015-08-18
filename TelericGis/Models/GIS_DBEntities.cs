using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TelericGis.Models
{
    public class GIS_DBEntities : DbContext
    {
       public DbSet<StreetRadiation> StreetRadiations { get; set; } 
    }
}