using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartApplication.Models
{
    public class SubCategory :Category
    {
        [Key]
        public int Scid { get; set; }
        public string Scname { get; set; }
       
       
        public SubCategory(int scid,string scname,int cid,string cname):base(cid,cname)
            
             
        {
            this.Scid = scid;
            this.Scname = scname;
            this.Cid = cid;
            this.Cname = cname;
           
        }
    }
}
