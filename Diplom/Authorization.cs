using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Authorization : Form
    {

        public Authorization()
        {

            InitializeComponent();
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_Click_1(object sender, EventArgs e)
        {
            Form1.CheckInfo();
        }
    }
}
