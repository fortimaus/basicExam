using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class Region
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;

        public virtual List<Patient> Patients { get; set; } = new();
    }
}
