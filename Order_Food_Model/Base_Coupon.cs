using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Order_Food_Model
{
	 public class Base_Coupon
	 {
		 public int  CouPon_Id { get; set; }
		 public decimal  CouPon_Money { get; set; }
		 public DateTime  ConPon_EndDate { get; set; }
		 public int  Number { get; set; }
		 public int  Type_Id { get; set; }
		 public int  CHold_Id { get; set; }
	 }
}
