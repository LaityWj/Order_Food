using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Order_Food_Model
{
	 public class Base_Menus
	 {
		 
		 public int  Menu_Id { get; set; }
		 public string  Menu_Name { get; set; }
		 public string  Menu_Pecture { get; set; }
		 public decimal  Menu_Price { get; set; }
		 public string  Menu_YL { get; set; }
		 public string  Menu_Desc { get; set; }
		 public int  Menu_State { get; set; }
		 public int  Food_Id { get; set; }

		public string Food_Name { get; set; }
		public int Dining_id { get; set; }
	}
}
