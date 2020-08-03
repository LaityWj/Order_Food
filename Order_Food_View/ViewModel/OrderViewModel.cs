using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Food_View.ViewModel
{
    public class OrderViewModel
    {
        public int order_Id { get; set; }
        public int Order_State { get; set; }
        public string Menu_Name { get; set; }
        public string Menu_Pecture { get; set; }
        //public int Order_State { get; set; }
        public string Order_No { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public string strState { get; set; }
        public int OrderId { get; set; }
        public int Type_Id { get; set; }

        public string Address_Detail { get; set; }
        public string Shou_Tel { get; set; }
        public string Shou_Name { get; set; }
        public string Shou_Sheng { get; set; }
        public string Show_Shi { get; set; }
        public int Shou_Id { get; set; }
        public string Shou_Qu { get; set; }
        public int State { get; set; }



        public string OrderNo { get; set; }
        public int Menu_Id { get; set; }
        // public int Number { get; set; }


        public decimal Menu_Price { get; set; }
        public string Menu_YL { get; set; }
        public string Menu_Desc { get; set; }
        public int Menu_State { get; set; }
        public int Food_Id { get; set; }

        public string Food_Name { get; set; }
        public int Dining_id { get; set; }



        public string Type_Name { get; set; }
    }
}
