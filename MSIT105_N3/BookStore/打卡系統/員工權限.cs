using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 員工權限
{
    public partial class 權限設定 : Form
    {
        public 權限設定()
        {
            InitializeComponent();
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
