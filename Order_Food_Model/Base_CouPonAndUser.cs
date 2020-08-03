using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Order_Food_Model
{
	 public class Base_CouPonAndUser
	 {
		 
		 public int  id { get; set; }
		 public int  ConPon_Id { get; set; }
		 public int  User_Id { get; set; }
		 public DateTime  CreateDate { get; set; }
		 public DateTime  EndDate { get; set; }
	 }
}
