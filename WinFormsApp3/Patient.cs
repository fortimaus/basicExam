using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class Patient
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public int age { get; set; }
        [ForeignKey("regionId")]
        public int regionId { get; set; }
        public virtual Region region { get; set; } = new();

        public override string ToString()
        {
            return $"{id}: {name} {age} years";
        }
    }
}
