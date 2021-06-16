using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesiWindowsFormsApp
{
    public class MyClass
    {
        private Button _btn;

        public MyClass(Button btn)
        {
            this._btn = btn;
            _btn.Click += new System.EventHandler( _btn_Click);
        }

        private void _btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click handled by Myclass");
        }
    }
}
