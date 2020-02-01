using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmartApplication.Models
{
    public class Category
    {
        public int Cid { get; set; }
        public string Cname { get; set; }
      
        public Category(int cid,string cname)
        {
            this.Cid = cid;
            this.Cname = cname;
         
        }
    }
}
