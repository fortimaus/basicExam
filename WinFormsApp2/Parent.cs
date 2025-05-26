using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Parent
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public int age { get; set; }
        public string work { get; set; } = string.Empty;

        [JsonIgnore]
        public virtual List<Child> childs { get; set; } = new();
        public override string ToString()
        {
            return $"id: {id} name: {name} age: {age} work: {work}";
        }
    }
}
