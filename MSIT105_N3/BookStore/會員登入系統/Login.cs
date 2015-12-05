using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.textBox2.PasswordChar = '*';
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();            //Hide the main application
                MainForm frm = new MainForm();       // Creat the login application
                frm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
