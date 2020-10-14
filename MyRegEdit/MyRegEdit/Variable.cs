using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRegEdit
{
    [Serializable]
    class Variable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public Variable(string name, string type, string value)
        {
            this.Name = name;
            this.Type = type;
            this.Value = value;
        }
    }
}
