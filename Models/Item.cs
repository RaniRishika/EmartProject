using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartApplication.Models
{
    public class Item
    {
        [Key]
        public int Ino { get; set; }
        public int Noi{ get; set; }
        public int Price { get; set; }
        public string Desc{ get; set; }
        public string Sname { get; set; }
        public int Scid { get; set; }
        public string Name { get; set; }
        public int Cid { get; set; }
        public string Cname { get; set; }
        public string Scname { get; set; }
        public Item(int ino,int noi,int price,string desc,int scid,string name,int cid,string Cname,string Scname)
        {
            this.Ino = ino;
            this.Noi = noi;
            this.Price = price;
            this.Desc = desc;
            this.Scid = scid;
            this.Name = name;
            this.Cid = cid;
            this.Cname = Cname;
            this.Scname = Scname;
        }
        public Item()
        {

        }
    }
}
