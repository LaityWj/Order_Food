using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Order_Food_Model
{
    public class Base_Order
    {
        public int Order_Id { get; set; }
        public string Order_No { get; set; }
        public decimal Price { get; set; }
        public int Order_State { get; set; }
        public int Type_Id { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime PayDateTime { get; set; }
        public int Pay_Id { get; set; }
        public int Shou_Id { get; set; }
        public int User_Id { get; set; }
        public string Remark { get; set; }
    }
}
