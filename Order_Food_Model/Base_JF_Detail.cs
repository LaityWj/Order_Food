using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Order_Food_Model
{
	public class Base_JF_Detail
	{
		 
		public int Detail_Id { get; set; }
		public int JF_Id { get; set; }
		public int User_Id { get; set; }
		public DateTime CreateTime { get; set; }
		public int Number { get; set; }
		//֧���Ļ���Ϊ1���õ��Ļ���Ϊ0
		public int State { get; set; }
	}
}
