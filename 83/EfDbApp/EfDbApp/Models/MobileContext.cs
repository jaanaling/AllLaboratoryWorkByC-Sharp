using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace EfDbApp.Models
{
    public class MobileContext : DbContext
    {
        public MobileContext() : base("EfDbApp.Properties.Settings.mobiledbConnectionString")
        {

        }
        public DbSet<Phone> Phones { get; set; }
    }


}
