using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCoreDC
{
    public partial class BufferedControl : UserControl
    {
        public BufferedControl()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }
    }
}
