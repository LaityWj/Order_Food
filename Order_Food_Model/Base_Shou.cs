using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Order_Food_Model
{
	 public class Base_Shou
	 {
		
		public int Shou_Id { get; set; }
		public string Address_Detail { get; set; }
		public string Shou_Tel { get; set; }
		public string Shou_Name { get; set; }
		public string Shou_Sheng { get; set; }
		public string Show_Shi { get; set; }
		public string Shou_Qu { get; set; }
		public int State { get; set; }
		public int User_Id { get; set; }
	}
}
