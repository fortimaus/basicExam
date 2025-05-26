using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Entity
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;

        public string phone { get; set; } = string.Empty;
        public int age { get; set; } = 0;

        public string country { get; set; } = string.Empty;
        public virtual List<Child> childs { get; set; } = new();

        public override string ToString()
        {
            return $"id: {id} name: {name} age: {age} phone: {phone} country:{country}";
        }
    }
}
