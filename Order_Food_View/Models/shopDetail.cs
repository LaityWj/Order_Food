using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Food_View.Models
{
    public class shopDetail
    {
        public int JF_Id { get; set; }
        public int Menu_Id { get; set; }
        public string Menu_Name { get; set; }
        public int Need_JF { get; set; }
        public string NeedDateTime { get; set; }
        public int Number { get; set; }
        public string Menu_Pecture { get; set; }
    }
}
