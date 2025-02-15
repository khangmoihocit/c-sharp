using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_5_6_2
{
    internal class CustomListItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public override string ToString()
        {
            return this.Text;
        }
    }
}
