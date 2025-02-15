using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai31_combobox
{
    public class PhuongThucThanhToan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int phi {  get; set; }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
