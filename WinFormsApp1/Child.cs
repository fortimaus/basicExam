using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Child
    {
        public string name { get; set; } = string.Empty;
        [ForeignKey("ParentId")]
        public int id { get; set; }
        public virtual Entity entity { get; set; } = new();
    }
}
