using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Diagnostics;
using System.Xml.Linq;

namespace sign_up.log_in
{
    public class TV
    {
        public int id { get; set; }
        public int inch { get; set; }
        public string model { get; set; }
        public int price { get; set; }
        public string discription { get; set; }
        public string company { get; set; }
    }
}
