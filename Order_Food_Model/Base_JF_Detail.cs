using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Order_Food_Model
{
	 public class Base_JF_Detail
	 {
		 public int  Detail_Id { get; set; }
		 public string  Order_No { get; set; }
		 public DateTime  Jf_GetDateTime { get; set; }
		 public DateTime  Jf_SellDateTime { get; set; }
		 public int  JF_Id { get; set; }
		 public int  User_Id { get; set; }
	 }
}
