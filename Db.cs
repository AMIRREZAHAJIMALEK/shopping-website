using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sign_up.log_in
{
    public class Db : DbContext
    {
        public Db() : base("dbk")
        {

        }
        public DbSet<Sign_up> Sign_Ups { get; set; }
        public DbSet<TV> TVs { get; set; }
        public DbSet<KEYBOARD> Keyboards { get; set; }
        public DbSet<MOBILE> Mobiles { get; set; }
        public DbSet<LAPTOP> LAPTOPs { get; set; }
        public DbSet<MOUSE> Mouses { get; set; }
    }
}
