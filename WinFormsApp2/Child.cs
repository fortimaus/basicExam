using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Child
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        
        [ForeignKey("parentId")]
        public int parentId { get; set; }

        public virtual Parent parent { get; set; } = new();

    }
}
