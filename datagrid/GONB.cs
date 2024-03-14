using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datagrid
{
    internal class GONB : Button
    {
        public int szám = 0;

        public GONB()
        {
            BackColor = Color.Fuchsia();
            Height = 200;
            Width = 200;
            Text = szám.ToString();
            
        }
    }
}
