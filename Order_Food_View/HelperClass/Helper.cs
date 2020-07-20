using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Food_View.HelperClass
{
    public class Helper
    {
        public string ResType(string url)
        {
            //this.Client.Share.SendText(url);
            return "";
        }

    }
    public class Base_Food_Menus
    {
        public int Food_Id { get; set; }
        public string Food_Name { get; set; }
        public int Dining_id { get; set; }
    }
    public class Base_Menus
    {
        public int Menu_Id { get; set; }
        public string Menu_Name { get; set; }
        public string Menu_Pecture { get; set; }
        public decimal Menu_Price { get; set; }
        public string Menu_YL { get; set; }
        public string Menu_Desc { get; set; }
        public int Menu_State { get; set; }
        public int Food_Id { get; set; }
    }
}
