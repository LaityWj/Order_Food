using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order_Food_View.ViewModel
{
    public class ShowCarModel
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Number { get; set; }
    }
}
