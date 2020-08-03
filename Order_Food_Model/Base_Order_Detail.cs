using System;
using System.Collections.Generic;

using System.Text;

namespace Order_Food_Model
{
    public class Base_Order_Detail
    {
        
        public int OrderDetail_Id { get; set; }
        public string OrderNo { get; set; }
        public int Menu_Id { get; set; }
        public int Number { get; set; }
    }
}
